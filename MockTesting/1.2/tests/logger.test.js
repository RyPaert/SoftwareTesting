const { logger, doWork } = require('../src/logger');

test('doWork calls logger.info twice with "started" and "finished"', () => {
  const spy = jest.spyOn(logger, 'info');

  doWork();

  expect(spy).toHaveBeenCalledTimes(2);
  expect(spy).toHaveBeenNthCalledWith(1, 'started');
  expect(spy).toHaveBeenNthCalledWith(2, 'finished');

  spy.mockRestore();
});

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaltechGuideWebAPI.Models;

namespace TaltechGuideWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ToodeController : ControllerBase
    {
        private static Toode _toode = new Toode(1, "Koola", 1.5, true);

        [HttpGet("toode")]
        public Toode GetToode()
        {
            return _toode;
        }
        [HttpGet("suurenda-hinda")]
        public Toode SuurendaHinda()
        {
            _toode.Price = _toode.Price + 1;
            return _toode;
        }
        [HttpGet("changeactivity")]
        public Toode changeActivity()
        {
            if (_toode.IsActive == true)
            {
                _toode.IsActive = false;
            }
            else
            {
                _toode.IsActive = true;
            }
            return _toode;
        }
        [HttpGet("changename/{name}")]
        public Toode changeName(string name)
        {
            _toode.Name = name;
            return _toode;
        }
        [HttpGet("multiplyprice/{mult}")]
        public Toode multiplyPrice(int mult)
        {
            double price = _toode.Price;
            double result = price * mult;
            _toode.Price = result;
            return _toode;
        }
    }
}

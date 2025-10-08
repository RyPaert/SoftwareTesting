namespace TaltechGuideWebAPI.Models
{
    public class Konto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Konto(Guid id, string name, string password, string firstname, string lastname)
        {
            Id = id;
            Name = name;
            Password = password;
            firstName = firstname;
            lastName = lastname;

        }
    }
}

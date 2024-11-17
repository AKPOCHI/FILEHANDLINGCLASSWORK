namespace FileHandling.Models
{
    public class Filer
    {
        //public Filer(string name, string phoneNumber, string email)
        //{
        //    Id  = Guid.NewGuid();
        //    Name = name;
        //    PhoneNumber = phoneNumber;
        //    Email = email;
        //}

        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

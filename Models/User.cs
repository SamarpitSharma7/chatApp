
using System.ComponentModel.DataAnnotations;


namespace chatApp.Models
{
    public class User
    {
        public User()
        {
        }

        public User(Guid id, string name, string email, string picture, string password, DateTime timeStamp)
        {
            Id = id;
            Name = name;
            Email = email;
            Picture = picture;
            Password = password;
            TimeStamp = timeStamp;
        }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }= "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.freepik.com%2F256%2F1077%2F1077114.png&tbnid=QBp1otvF6AgHdM&vet=12ahUKEwje3vqnscmEAxUGq2MGHTNqCyAQMygIegUIARCDAQ..i&imgrefurl=https%3A%2F%2Fwww.freepik.com%2Ficons%2Fuser&docid=yC2pK8Mg3lF9dM&w=256&h=256&q=user%20png&ved=2ahUKEwje3vqnscmEAxUGq2MGHTNqCyAQMygIegUIARCDAQ";
        public string Password { get; set; }
        
        public DateTime TimeStamp { get; set; } =DateTime.UtcNow;
    }
}
using System.Security.Cryptography.X509Certificates;

namespace BookMyMeal.Models.DTO
{
    public class LoginDTO
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}

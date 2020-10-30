using Microsoft.EntityFrameworkCore;
namespace StoreAppDB.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string password { get; set; }


    }
}
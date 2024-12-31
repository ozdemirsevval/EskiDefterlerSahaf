using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public ICollection<Address> Addresses { get; set; } 
        public ICollection<Order> Orders { get; set; }

        public int RoleId { get; set; } = 1; //ForeignKey
        public Role Role { get; set; } //NavigationProperty
    }
}

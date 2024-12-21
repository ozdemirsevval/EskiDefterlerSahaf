using EskiDefterler.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.Core.Entities.Concrete
{
    public class Role : BaseEntity
    {
        public string RoleTitle { get; set; }
        public ICollection<User> Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entites.Commen
{
    public class RoleUser
    {
        public int Userid { get; set; }
        public int Roleid { get; set; }
        public bool IsActive { get; set; }
    }
}

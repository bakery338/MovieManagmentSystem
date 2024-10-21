using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entites.Commen
{
    public class Catogery
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Parentid { get; set; }
    }
}

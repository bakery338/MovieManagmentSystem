using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entites.Commen
{
    public class Role
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public required string Name { get; set; }
    }
}

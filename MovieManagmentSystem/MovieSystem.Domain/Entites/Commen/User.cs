using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entites.Commen
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public short? Age { get; set; }
        [MaxLength(20)]
        public string? Type { get; set; }

        public ICollection<Review>? reviews { get; set; }
        public ICollection<Like>? likes { get; set; }
       

    }
}

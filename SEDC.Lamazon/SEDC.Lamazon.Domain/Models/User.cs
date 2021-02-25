using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEDC.Lamazon.Domain.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [StringLength(20, MinimumLength = 5)]
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<Order> Orders { get; set; }
    }
}

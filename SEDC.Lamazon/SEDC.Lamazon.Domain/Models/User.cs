using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SEDC.Lamazon.Domain.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public List<Order> Orders { get; set; }
    }
}
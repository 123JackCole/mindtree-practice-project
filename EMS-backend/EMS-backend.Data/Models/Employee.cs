using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_backend.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]

        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        [Required]
        public string Role { get; set; }
    }
}

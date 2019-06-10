using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAuth.Models
{
    public class Owner
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address cannot be loner then 100 characters")]
        public string Address { get; set; }
    }
}

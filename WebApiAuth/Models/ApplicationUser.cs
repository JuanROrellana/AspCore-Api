using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApiAuth.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {

        }

        [Column(TypeName =  "nvarchar(150)")]
        public string FullName { get; set; }

    }
}

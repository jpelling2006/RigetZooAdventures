using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


//https://www.tektutorialshub.com/asp-net-core/add-custom-fields-to-user-in-asp-net-core-identity/
namespace RigetZooAdventures.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Title")]
        [MaxLength(5)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(256)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(256)]
        public string LastName { get; set; }
    }
}

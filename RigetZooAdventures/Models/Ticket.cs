using Microsoft.AspNetCore.Mvc;
using RigetZooAdventures.Data;
using RigetZooAdventures.Models;
using System.ComponentModel.DataAnnotations;

namespace RigetZooAdventures.Models
{
    public class Tickets
    {
        [Key]
        [Display(Name = "Ticket Id")]
        public int TicketId { get; set; }

        [Display(Name = "Booked Date")]
        [DataType(DataType.Date)]
        public DateTime BookedDate { get; set; }

        [Display(Name = "Username")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required(ErrorMessage = "At least one adult must be on the booking!")]
        [Range(1, 100)]
        public int Adults { get; set; }

        [Range(0, 100)]
        public int? Children { get; set; }

        [Required]
        [Display(Name = "Is Education")]
        public bool IsEducation { get; set; }

        [Display(Name = "School Name")]
        [MaxLength(256)]
        public string? SchoolName { get; set; }

        [Required]
        [Display(Name = "Date on Ticket")]
        [DataType(DataType.Date)]
        public DateTime ValidDate { get; set; }

    }
}

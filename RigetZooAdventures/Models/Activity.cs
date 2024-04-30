using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RigetZooAdventures.Models
{
    public class Activities
    {
        [Key]
        [Display(Name = "Activity Id")]
        public int ActivityId { get; set; }

        [Required]
        [Display(Name = "Activity Name")]
        [MaxLength(256)]
        public string ActivityName { get; set; }

        [Display(Name = "Activity Location")]
        [MaxLength(256)]
        public string? ActivityLocation { get; set; }
    }

    public class BookedActivities
    {
        [Key]
        [Display(Name = "Booked Activity Id")]
        public int BookedActivityId { get; set; }

        [Display(Name = "Ticket Id")]
        public int TicketId { get; set; }
        public Tickets? Ticket { get; set; }

        [Required]
        [Display(Name = "Activity Id")]
        public int ActivityId { get; set; }
        public Activities? Activity { get; set; }

        [Required]
        [Display(Name = "Booked Date")]
        [DataType(DataType.Date)]
        public DateTime BookedDate { get; set; }
    }
}

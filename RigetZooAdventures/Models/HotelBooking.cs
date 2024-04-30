using RigetZooAdventures.Data;
using System.ComponentModel.DataAnnotations;

namespace RigetZooAdventures.Models
{
    public class HotelBooking
    {
        [Key]
        [Display(Name = "Hotel Booking ID")]
        public int HotelBookingID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "User Id")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required(ErrorMessage = "At least one adult must be on the booking!")]
        [Range(1, 100)]
        public int Adults { get; set; }

        [Range(0, 100)]
        public int? Children { get; set; }

        [Required]
        [Display(Name = "Room Type")]
        public string RoomType { get; set; } // link to rooms in the future

        [Required]
        [Range(1, 20)]
        [Display(Name = "Amount of Rooms")]
        public int RoomAmount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Booked")]
        public DateTime DateBooked { get; set; }
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StageSyncApp.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        [Display(Name = "Venue")]
        public string VenueName { get; set; }
        [Display(Name = "Stage")]
        public string StageName { get; set; }
        [Display(Name = "Booking Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingDate { get; set; }
        [DefaultValue(null)]
        public int? ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}

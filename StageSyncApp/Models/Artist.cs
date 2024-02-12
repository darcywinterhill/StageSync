using System.ComponentModel.DataAnnotations;

namespace StageSyncApp.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Display(Name = "Artist")]
        public string ArtistName { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}

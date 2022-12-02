using System.ComponentModel.DataAnnotations;

namespace PKRTravels.Models
{
    //Creating the model of PKR Travels
    public class TravelsDB
    {
        [Key]
        public int BusId { get; set; }
        [Required]
        public string BoardingPoint { get; set; }
        [Required]
        public DateTime TravelDate { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public int Rating { get; set; }

    }
}

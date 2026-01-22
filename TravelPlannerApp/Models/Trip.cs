using System.ComponentModel.DataAnnotations;

namespace TravelPlannerApp.Models
{
    public class Trip
    {
        public int Id { get; set; }

        [Required]
        public string Destination { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal Budget { get; set; }
    }
}

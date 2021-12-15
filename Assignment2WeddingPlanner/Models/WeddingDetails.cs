using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WeddingPlanner.Models
{
    public class WeddingDetails
    {
        [Required]
        public int WeddingID { get; set; }

        [Required]
        public string BrideName { get; set; }

        [Required]
        public string GroomName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime WeddingDate { get; set; }

        [Required]
        public int NumOfGuests { get; set; }

        [Required]
        public string CeremonyVenue { get; set; }

        [Required]
        public string ReceptionVenue { get; set; }

        public ICollection<WeddingPlanner> WeddingPlanners { get; set; }
    }
}

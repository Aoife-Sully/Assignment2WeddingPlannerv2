using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WeddingPlanner.Models
{
    public class WeddingPlanner
    {
        [Required]
        public int PlannerID { get; set; }

        [Required]
        public string PlannerName { get; set; }

        [Required]
        [EmailAddress]
        public string PlannerEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PlannerPassword { get; set; }

        public WeddingDetails WeddingDetails { get; set; }

        public UserEnquiry UserEnquiry { get; set; }
    }
}

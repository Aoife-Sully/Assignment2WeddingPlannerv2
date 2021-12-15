using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WeddingPlanner.Models
{
    public class UserEnquiry
    {
        [Required]
        public int EnquiryID { get; set; }

        [Required]
        public string CoupleName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [Phone]
        public int PhoneNumber { get; set; }

        [Required]
        public string EnquiryMessage { get; set; }

        public ICollection<WeddingPlanner> WeddingPlanners { get; set; }
    }
}

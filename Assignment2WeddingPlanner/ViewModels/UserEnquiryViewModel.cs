using Assignment2WeddingPlanner.Helpers;
using Assignment2WeddingPlanner.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WeddingPlanner.ViewModels
{
    public class UserEnquiryViewModel
    {
        public List<UserEnquiry> UserEnquiries { get; set; }

        public UserEnquiry EditableEnquiry { get; set; }

        public UserEnquiryViewModel()
        {
            using (var db = DbHelpers.GetConnection())
            {
                this.EditableEnquiry = new UserEnquiry();

                this.UserEnquiries = db.Query<UserEnquiry>("Select * From dbo.UserEnquiry").ToList();
            }
        }
    }

}

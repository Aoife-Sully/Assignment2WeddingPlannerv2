using Assignment2WeddingPlanner.Helpers;
using Assignment2WeddingPlanner.Models;
using Assignment2WeddingPlanner.ViewModels;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WeddingPlanner.Controllers
{
    public class UserEnquiryController : Controller
    {
        public IActionResult Index()
        {
            UserEnquiryViewModel userEnquiry = new UserEnquiryViewModel(); 

            return View("Index", userEnquiry);
        }

        public IActionResult CreateUpdate(UserEnquiryViewModel userEnquiry)
        {
            if(ModelState.IsValid)
            {
                using (var db = DbHelpers.GetConnection())
                {
                    if (userEnquiry.EditableEnquiry.EnquiryID == null)
                    {
                        userEnquiry.EditableEnquiry.EnquiryID = userEnquiry.UserEnquiries.Count + 1;

                        db.Insert<UserEnquiry>(userEnquiry.EditableEnquiry);
                    }

                    else
                    {
                        UserEnquiry dbItem = db.Get<UserEnquiry>(userEnquiry.EditableEnquiry.EnquiryID);

                        TryUpdateModelAsync<UserEnquiry>(dbItem, "EditableEnquiry");

                        db.Update<UserEnquiry>(dbItem);
                    }
                }

                return RedirectToAction("Index", userEnquiry);
            }

            else
            {
                return View("ViewUserEnquiry", new UserEnquiryViewModel());
            }
        }

        public IActionResult EditDetails(int Id)
        {
            UserEnquiryViewModel userEnquiry = new UserEnquiryViewModel();

            userEnquiry.EditableEnquiry = userEnquiry.UserEnquiries.FirstOrDefault(x => x.EnquiryID == Id);

            return View("Index", userEnquiry);
        }


    }
}

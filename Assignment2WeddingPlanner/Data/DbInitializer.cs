using Assignment2WeddingPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WeddingPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PlannerContext context)
        {
            context.Database.EnsureCreated();

            //Look for enquiries
            if (context.UserEnquiries.Any())
            {
                return; //DB has been seeded
            }

            //Initialising data for User Enquiries
            var enquiry = new UserEnquiry[]
            {
                new UserEnquiry{CoupleName = "Eimear and Tim", EmailAddress = "eimear@gmail.com", PhoneNumber = 0861234567, EnquiryMessage = "Hello, we are looking for someone to help us plan our wedding, for November 2022"},
                new UserEnquiry{CoupleName = "Aoife and Rory", EmailAddress = "aoife@gmail.com", PhoneNumber = 0861234567, EnquiryMessage = "Do you help to organise weddings abroad? We are hoping to elope in Spain next July"},
                new UserEnquiry{CoupleName = "Aine and Peter", EmailAddress = "peterm@gmail.com", PhoneNumber = 0871234567, EnquiryMessage = "We are planning a big wedding for 250 guests in March, can you help us?"},
            };

            foreach (UserEnquiry u in enquiry)
            {
                context.UserEnquiries.Add(u);
            }
            context.SaveChanges();


            //Initialising data for Wedding Details
            var details = new WeddingDetails[]
            {
                new WeddingDetails{BrideName = "Eimear", GroomName = "Tim", WeddingDate = DateTime.Parse("25/11/2022"), NumOfGuests = 250, CeremonyVenue = "St Mary's Church Mallow", ReceptionVenue = "Castletroy Hotel"},
                new WeddingDetails{BrideName = "Aoife", GroomName = "Rory", WeddingDate = DateTime.Parse("25/11/2022"), NumOfGuests = 120, CeremonyVenue = "Gougane Barra Church", ReceptionVenue = "Bantry House"},
                new WeddingDetails{BrideName = "Aine", GroomName = "Peter", WeddingDate = DateTime.Parse("25/11/2022"), NumOfGuests = 60, CeremonyVenue = "Clarion Hotel Cork", ReceptionVenue = "Clarion Hotel Cork"}
            };

            foreach (WeddingDetails d in details)
            {
                context.WeddingDetails.Add(d);
            }
            context.SaveChanges();


            //Initialising data for Wedding Planner
            var planner = new WeddingPlanner[]
            {
                new WeddingPlanner{PlannerName = "Carla", PlannerEmail = "CarlaK@Nuptials.com", PlannerPassword = "password"},
                new WeddingPlanner{PlannerName = "Aimee", PlannerEmail = "AimeeC@Nuptials.com", PlannerPassword = "password"},
                new WeddingPlanner{PlannerName = "Meghan", PlannerEmail = "MeghanO@Nuptials.com", PlannerPassword = "password"},
            };

            foreach(WeddingPlanner p in planner)
            {
                context.WeddingPlanners.Add(p);
            }
            context.SaveChanges();

        }
    }
}

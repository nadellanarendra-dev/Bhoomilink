using System.Diagnostics;
using Bhoomilink.Models;
using Microsoft.AspNetCore.Mvc;


namespace Bhoomilink.Controllers
{
    public class PropertyController : Controller
    {

        public IActionResult BuyProperties()
        {

            var properties = new List<Property>
            {

                new Property{
                    Id=1,
                    Title="2BHK Apartment",
                    Type="Apartment",
                    Location="Madhurawada",
                    Price=6800000,
                    Area="1350 SFT",
                    Bedrooms=2,
                    Bathrooms=2,
                    Facing="East",
                    Status="Ready To Move",
                    ImageUrl="https://picsum.photos/600/400?random=1",
                    Description="Beautiful apartment near IT SEZ.",
                    OwnerVerified=true,
                    LoanEligible=true,
                    DTCPApproved=true
                },

                new Property{
                    Id=2,
                    Title="Open Plot",
                    Type="Plot",
                    Location="Anandapuram",
                    Price=3200000,
                    Area="200 Sq.Yards",
                    Bedrooms=0,
                    Bathrooms=0,
                    Facing="North",
                    Status="Available",
                    ImageUrl="https://picsum.photos/600/400?random=2",
                    Description="DTCP Approved Open Plot.",
                    OwnerVerified=true,
                    LoanEligible=true,
                    DTCPApproved=true
                }

            };


            string[] locations =
            {
                "PM Palem",
                "Rushikonda",
                "Kommadi",
                "Yendada",
                "Gajuwaka",
                "Bheemunipatnam",
                "MVP Colony",
                "Sujatha Nagar",
                "Pendurthi",
                "Tagarapuvalasa",
                "Madhurawada",
                "Anandapuram"
            };

            int id = 3;

            foreach (var loc in locations)
            {

                properties.Add(new Property
                {
                    Id = id++,
                    Title = "Premium Villa",
                    Type = "Villa",
                    Location = loc,
                    Price = 12500000,
                    Area = "2500 SFT",
                    Bedrooms = 3,
                    Bathrooms = 3,
                    Facing = "East",
                    Status = "Ready To Move",
                    ImageUrl = $"https://picsum.photos/600/400?random={id}",
                    Description = "Luxury Villa with premium amenities.",
                    OwnerVerified = true,
                    LoanEligible = true,
                    DTCPApproved = true
                });

                properties.Add(new Property
                {
                    Id = id++,
                    Title = "Residential Plot",
                    Type = "Plot",
                    Location = loc,
                    Price = 4500000,
                    Area = "267 Sq.Yards",
                    Bedrooms = 0,
                    Bathrooms = 0,
                    Facing = "North",
                    Status = "Available",
                    ImageUrl = $"https://picsum.photos/600/400?random={id}",
                    Description = "Excellent investment opportunity.",
                    OwnerVerified = true,
                    LoanEligible = false,
                    DTCPApproved = true
                });

            }

            return View(properties);

        }

        public IActionResult Details(int id)
        {
            var property = new Property
            {
                Id = id,
                Title = "2BHK Premium Apartment",
                Type = "Apartment",
                Location = "Madhurawada, Visakhapatnam",
                Price = 6800000,
                Area = "1350 SFT",
                Bedrooms = 2,
                Bathrooms = 2,
                Facing = "East",
                Status = "Ready To Move",
                ImageUrl = "https://picsum.photos/1000/600?random=100",
                Description = "Beautiful 2BHK apartment located near IT SEZ, schools, hospitals and shopping malls. Ideal for families looking for a peaceful and modern lifestyle.",
                OwnerVerified = true,
                LoanEligible = true,
                DTCPApproved = true
            };

            return View(property);
        }

    }
}

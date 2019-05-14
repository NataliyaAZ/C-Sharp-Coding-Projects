using QuoteVMC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Web.WebPages;

namespace QuoteVMC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(string firstName, string lastName, string emailAddress, string dateOfBirth, string carYear, string carMake,
                                   string carModel, string dui, string speedingTickets, string insType)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) ||
                string.IsNullOrEmpty(dui) || string.IsNullOrEmpty(speedingTickets) || string.IsNullOrEmpty(insType))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else //Recording into DB
            {
                using (QuoteEntities db = new QuoteEntities())
                {
                    var customer = new Customer();
                    customer.FirstName = firstName;
                    customer.LastName = lastName;
                    customer.EmailAddress = emailAddress;
                    customer.DateOfBirth = dateOfBirth.AsDateTime();
                    customer.CarYear = carYear;
                    customer.CarMake = carMake;
                    customer.CarModel = carModel;
                    customer.DUI = dui;
                    customer.SpeedingTickets = Convert.ToInt32(speedingTickets);
                    customer.InsType = insType;

                    //Quote Calculation
                    int monthlyBaseAmount = 50;
                    int monthlyAgeAmount = 0;
                    int monthlyCarYearAmount = 0;
                    int monthlyCarMakeAmount = 0;
                    int monthlyCarModelAmount = 0;
                    int monthlySpeedTicketsAmount = 0;

                    //Calculating age and extra amount depending on the age
                    DateTime dob = DateTime.Parse(dateOfBirth);                                         
                    int age = DateTime.Now.Year - dob.Year;
                    if (DateTime.Now.DayOfYear < dob.DayOfYear)
                    {
                        age = age - 1;
                    }
                    if (age<18)
                    {
                       monthlyAgeAmount = 100;
                    }
                    else if(age<25 && age>=18 )
                    {
                       monthlyAgeAmount = 25;
                    }
                    else if (age>100)
                    {
                        monthlyAgeAmount = 25;
                    }

                    //Calculating extra amount depending on the year car made
                    int year = Convert.ToInt32(carYear);
                    if ( year<2000 || year>2015)
                    {
                        monthlyCarYearAmount = 25;
                    }

                    //Calculating extra amount depending on the car manufacture and model
                    string carName = carMake.ToLower();
                    string carMod = carModel.ToLower();
                    if (carName == "porsche")
                    {
                        monthlyCarMakeAmount = 25;
                    }
                    if(carName == "porsche" && carMod == "911 carrera")
                    {
                        monthlyCarModelAmount = 25;
                    }

                    //Calculating extra amount depending on number of speeding tickets
                    monthlySpeedTicketsAmount = 10 * Convert.ToInt32(speedingTickets);

                    //Calculation Total
                    double totalAmount = monthlyBaseAmount + monthlyAgeAmount + monthlyCarYearAmount + monthlyCarMakeAmount + monthlyCarModelAmount + monthlySpeedTicketsAmount;
                    
                    //Calculating Total depending on if DUI ever happened
                    string duiExist = dui.ToLower();
                    if (duiExist == "yes")
                    {
                        totalAmount = 1.25 * totalAmount;
                    }
                    
                    //Calculating Total depending on insurance cover choice
                    string insCover = insType.ToLower();
                    if (insCover == "full coverage")
                    {
                        totalAmount = Math.Round((1.5 * totalAmount),2);
                    }
                    
                    //Add quote amount into DB
                    customer.QuoteAmount = Convert.ToString(totalAmount);
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
                return View("Index");
            }
        }
    }
}
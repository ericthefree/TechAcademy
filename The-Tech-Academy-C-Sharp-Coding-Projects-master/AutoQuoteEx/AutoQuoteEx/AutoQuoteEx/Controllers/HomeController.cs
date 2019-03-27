//Home controller for the start page to post data to the database
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoQuoteEx.Models;

namespace AutoQuoteEx.Controllers
{
    public class HomeController : Controller
    {
        List<SelectListItem> ddlYears = new List<SelectListItem>();

        public ActionResult Index(int? CarYear)
        {
            ViewBag.carYear = GetYears(CarYear);

            return View();
        }

        private SelectList GetYears(int? mySelectedYear)
        {
            int oldestYear = 1885;
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= oldestYear; i--)
            {
                ddlYears.Add(new SelectListItem
                {
                    Text = i.ToString(),
                    Value = i.ToString()
                });
            }
            return new SelectList(ddlYears, "Value", "Text", mySelectedYear);
        }
        //Push the customer date from the form on the quote page into the database
        [HttpPost]
        public ActionResult GetCustomerDetail(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake,
            string carModel, string duiSelect, int speedTickets, string coverageType)
        {
            DateTime currentYear = new DateTime();
            int thisYear = currentYear.Year;

            //Push the user entered data into the Quotes table in the database
            using (AutoInsQuoteEntities db = new AutoInsQuoteEntities())
            {
                var customerDetail = new UserInfo();
                customerDetail.FirstName = firstName;
                customerDetail.LastName = lastName;
                customerDetail.EmailAddress = emailAddress;
                customerDetail.Dob = dateOfBirth.Date;
                customerDetail.CarYear = carYear;
                customerDetail.CarMake = carMake;
                customerDetail.CarModel = carModel;
                customerDetail.Dui = duiSelect.ToString();
                customerDetail.SpeedTickets = speedTickets;
                customerDetail.CoverageType = coverageType;
                db.UserInfoes.Add(customerDetail);
                
                db.SaveChanges();

                ViewBag.clientId = customerDetail.Id;

            }

            //Redirect the data into the quote controller to get the quote totals
            return RedirectToAction("MakeQuote","Quote", new { dateOfBirth, carYear, carMake, carModel, duiSelect, speedTickets, coverageType, ViewBag.clientId });
        }
    }
}
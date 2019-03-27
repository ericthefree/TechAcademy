using System;
using System.Web.Mvc;
using AutoQuoteEx.Models;

namespace AutoQuoteEx.Controllers
{
    public class QuoteController : Controller
    {
        public ActionResult Index()
        {
            return View();

        }

        // GET: Quote create the quote totals here and enter into the database
        public ActionResult MakeQuote(DateTime dateOfBirth, int carYear, string carMake, string carModel, string duiSelect, int speedTickets, string coverageType, int clientId)
        {           
            //Calculate the customer's age
            DateTime currentDate = DateTime.Now.Date;

            int customerAge = 0;
            if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
            {
                customerAge = currentDate.Year - dateOfBirth.Year - 1;
            }
            else
            {
                customerAge = currentDate.Year - dateOfBirth.Year;
            }

            //calculate totals for the quote based on age
            decimal baseTotal = 50.00m;

            decimal teenDriveTotal = (customerAge < 18) ? 100.00m : 0;
            decimal underAgeTotal = (customerAge >= 18 && customerAge < 25) ? 25.00m : 0;
            decimal overAgeTotal = (customerAge > 100) ? 25.00m : 0;

            //calculate total if it's an old car
            decimal oldCarTotal = (carYear < 2000) ? 25.00m : 0;

            //calculate total if it's a newer car
            decimal newCarTotal = (carYear > 2015) ? 25.00m : 0;

            //calculate total if the car is a sports car
            decimal sportsCarTotal = (carMake == "Porsche") ? 25.00m : 0;

            //calculate total if the car is an exotic car
            decimal exoticCarTotal = (carMake == "Porsche" && carModel.Contains("Carrera")) ? 25.00m : 0;

            //calculate subtotal of speedtickets
            decimal speedTicketTotal = speedTickets * 10.00m;

            //calculate subtotal of quote
            decimal subTotal = (baseTotal + teenDriveTotal + underAgeTotal + underAgeTotal + overAgeTotal + oldCarTotal + newCarTotal +
                    sportsCarTotal + exoticCarTotal + speedTicketTotal);

            //add 25% of subtotal if there's a dui
            decimal duiTotal = (duiSelect == "yes") ? Math.Round((subTotal * 0.25m),2) : 0;
            Math.Round(duiTotal, 2);

            //add 50% to the quote if it's full coverage
            decimal coverageTotal = (coverageType == "full") ? Math.Round(((subTotal + duiTotal) * 0.5m), 2) : 0;
           
            decimal quotePrice = Math.Round((subTotal + duiTotal + coverageTotal), 2);


            //Push the data to the QuoteTotals database table
            using (AutoInsQuoteEntities db = new AutoInsQuoteEntities())
            {
                var quotetotal = new QuoteTotal();
                quotetotal.QuoteDate = currentDate;
                quotetotal.BaseTotal = baseTotal;
                quotetotal.TeenDriveTotal = teenDriveTotal;
                quotetotal.UnderAgeTotal = underAgeTotal;
                quotetotal.OverAgeTotal = overAgeTotal;
                quotetotal.OldCarTotal = oldCarTotal;
                quotetotal.NewCarTotal = newCarTotal;
                quotetotal.SportCarTotal = sportsCarTotal;
                quotetotal.ExoticCarTotal = exoticCarTotal;
                quotetotal.SpeedTicketTotal = speedTicketTotal;
                quotetotal.DuiTotal = duiTotal;
                quotetotal.CoverageTotal = coverageTotal;
                quotetotal.QuoteFinalTotal = quotePrice;
                quotetotal.ClientId = clientId;

                db.QuoteTotals.Add(quotetotal);

                db.SaveChanges();

                //Setup ViewBag data for the quote page to display
                ViewBag.quoteDate = quotetotal.QuoteDate.ToShortDateString();
                ViewBag.quoteFinalTotal = quotetotal.QuoteFinalTotal;
                ViewBag.baseTotal = quotetotal.BaseTotal;
                ViewBag.underAgeTotal = quotetotal.UnderAgeTotal;
                ViewBag.teenDriveTotal = quotetotal.TeenDriveTotal;
                ViewBag.overAgeTotal = quotetotal.OverAgeTotal;
                ViewBag.oldCarTotal = quotetotal.OldCarTotal;
                ViewBag.newCarTotal = quotetotal.NewCarTotal;
                ViewBag.sportCarTotal = quotetotal.SportCarTotal;
                ViewBag.exoticCarTotal = quotetotal.ExoticCarTotal;
                ViewBag.speedTicketTotal = quotetotal.SpeedTicketTotal;
                ViewBag.duiTotal = quotetotal.DuiTotal;
                ViewBag.coverageTotal = quotetotal.CoverageTotal;
                ViewBag.quotePrice = quotetotal.QuoteFinalTotal;
       
            }
            //Open the main page in the Quote view to show the user the quote
            return View("../Quote/Index");
        }

        //Method to allow the user to create a new quote.  Goes back to the Home view
        public ActionResult NewQuote()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
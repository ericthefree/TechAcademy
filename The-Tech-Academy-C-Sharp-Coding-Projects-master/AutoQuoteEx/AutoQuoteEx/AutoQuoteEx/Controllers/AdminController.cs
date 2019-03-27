using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoQuoteEx.Models;
using AutoQuoteEx.ViewModels;

namespace AutoQuoteEx.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (AutoInsQuoteEntities db = new AutoInsQuoteEntities())
            {
                var quoteList = (from q in db.UserInfoes from ql in db.QuoteTotals where q.Id == ql.ClientId select new QuoteListVM
                {
                    QuoteDate = ql.QuoteDate, FirstName = q.FirstName, LastName = q.LastName,
                    EmailAddress = q.EmailAddress, QuoteFinalTotal = ql.QuoteFinalTotal
                }).ToList();

                var quoteVms = new List<QuoteListVM>();

                foreach(var quote in quoteList)
                {
                    var quoteVm = new QuoteListVM();

                    quoteVm.QuoteDate = quote.QuoteDate.Date;
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quoteVm.QuoteFinalTotal = quote.QuoteFinalTotal;
                    
                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }

        }
    }
}
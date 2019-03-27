using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoQuoteEx.ViewModels
{
    public class QuoteListVM
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal QuoteFinalTotal { get; set; }
        [DisplayFormat(DataFormatString = "{0;dd MMM yyyy")]
        public DateTime QuoteDate { get; set; }

    }
}
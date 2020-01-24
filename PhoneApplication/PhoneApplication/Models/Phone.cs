using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
        public Phone()
        {
            PhoneId = 0;
            PhoneName = "";
            Manufacture = "";
            MSRP = 0;
            ScreenSize = 0;
            Date = DateTime.Parse("01/01/2000") ;
        }
        public int PhoneId { get; set; }
        public string PhoneName { get; set; }
        public string Manufacture { get; set; }
        public double MSRP { get; set; }
        public double ScreenSize { get; set; }
        public DateTime Date { get; set; }

    }
}
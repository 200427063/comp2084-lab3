
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
       
        public ActionResult Index()
        {
            var phoneList = new List<Phone>
            {
                new Phone { PhoneName = "Samsung"},
                new Phone { PhoneName = "Apple"},
                new Phone { PhoneName = "Blackberry"},
                new Phone { PhoneName = "OnePlus"},
                new Phone { PhoneName = "Google"}

            };
            return View(phoneList);
        }
    }
}
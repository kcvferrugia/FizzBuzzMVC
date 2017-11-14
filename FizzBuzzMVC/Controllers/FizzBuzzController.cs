using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzMVC.Controllers
{
    public class FizzBuzzController : Controller
    {
        private string ToFizzBuzz(int value)
        {
            var isDivisibleByFive = value % 5 == 0;
            var isDivisibleByThree = value % 3 == 0;

            if (isDivisibleByThree) return "Fizz";

            return $"{value}";
        }

        // GET: FizzBuzz
        public ActionResult Index()
        {
            var model = Enumerable.Range(1, 100).Select(ToFizzBuzz);
            return View(model);
        }
    }
}
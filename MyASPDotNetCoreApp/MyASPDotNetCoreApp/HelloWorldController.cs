using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using MyASPDotNetCoreApp.Models;

namespace MyASPDotNetCoreApp
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action";
        }

        public string Xamarin(string name)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, welcome to Visual Studio for Mac");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult ScanTicket()
        {
            ViewData["Message"] = "Scan the Ticket";

            var viewModel = new Address()
            {
                Name = "Microsoft",
                Street = "One Microsoft Way",
                City = "Redmond",
                State = "WA",
                PostalCode = "98052-6399"
            };

            return View(viewModel);
        }
    }
}

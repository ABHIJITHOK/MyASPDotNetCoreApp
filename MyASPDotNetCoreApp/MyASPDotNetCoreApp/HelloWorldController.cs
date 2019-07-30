using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

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
    }
}

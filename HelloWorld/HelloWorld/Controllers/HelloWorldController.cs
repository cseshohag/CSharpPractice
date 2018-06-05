using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Welcome()
        {
            return "Welcome to our world";
        }

        public string Display(string Name)
        {
            return "Hi " + Name + " \nwelcome to my page" ;
        }

        public object Index()
        {
            ViewBag.Name = "Shohag";
            return View();
        }
    }
}
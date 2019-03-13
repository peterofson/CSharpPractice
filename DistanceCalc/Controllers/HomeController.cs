using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DistanceCalc.Models;

namespace DistanceCalc.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(AdditionViewModel model, string command, string push, string calc)
        {
            if ((command == "Miles") && (push == "Miles") && (calc == "Calculate"))
            {
                model.Miles = model.A + model.B;
                
            }
            if (command == "Yards")
            {
                model.Miles = model.A - model.B;
            }
            if (command == "Feet")
            {
                model.Miles = model.A * model.B;
            }

            return View(model);
        }


    }
}

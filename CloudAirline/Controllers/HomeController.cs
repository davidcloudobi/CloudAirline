using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AirLineServices.Interface;
using Microsoft.AspNet.Identity;

namespace CloudAirline.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAirlineServices airline;

        public HomeController( IAirlineServices airline)
        {
            
            this.airline = airline;
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var model = await airline.GetAllAirline();

            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> Index(string airlineName,string category)
        {
            if (category == "")
            {
                category = "0";
            }
            if (category != null || airlineName != null)
            {
                if (category != null)
                {
                    var model = await airline.GetAllAirlineFiltered(airlineName, int.Parse(category));
                    return View(model);
                }
            }

           
                var model2 = await airline.GetAllAirline();
                return View(model2);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}
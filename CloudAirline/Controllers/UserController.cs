using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudAirline.Controllers
{
    public class UserController : Controller
    {
        

        public UserController()
        {
           
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]

        public ActionResult GetUsers()
        {


            return View();
        }
    }
}
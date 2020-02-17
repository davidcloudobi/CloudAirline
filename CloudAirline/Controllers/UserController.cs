using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AirLine.Modules.Class;
using AirLineServices.Interface;

namespace CloudAirline.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices user;


        public UserController(IUserServices user)
        {
            this.user = user;
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]

        public async Task<ActionResult> GetUsers(int id)
        {
            var model = await user.GetUser(id);

            return View(model);
        }


        [HttpGet]

        public ActionResult Create()
        {
           // var model = user.AddUser()

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Create(User newUser)
        {
            if (ModelState.IsValid)
            {
                var model = user.AddUser(newUser);

                await user.Commit();
                return RedirectToAction("GetAllUsers");

            }

            return View();
        }


        [HttpGet]

        public async Task<ActionResult> GetAllUsers()
        {

            var model = await user.GetAllUsers();
            return View(model);
        }

        [HttpGet]

        public async Task<ActionResult> Edit(int id)
        {

            var model = await user.GetUser(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(User updateUser)
        {

            if (ModelState.IsValid)
            {
                var model = await user.UpdateUser(updateUser);
                await user.Commit();
                TempData["Message"] = $"{model.Name} was successfully updated";
                return RedirectToAction("GetAllUsers");
            }

            return View();
        }
    }
}
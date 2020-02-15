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
    public class AirlineController : Controller
    {
        private readonly IAirlineServices airline;

        public AirlineController(IAirlineServices airline)
        {
            this.airline = airline;
        }
        // GET: Airline

        public ActionResult Index()
        {
            return View();
        }

        //#################################################################################
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        //############ Create ###############
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Airline item)
        {
            if (ModelState.IsValid)
            {
                airline.AddAirline(item);
                var num = await airline.Commit();
            }
            return RedirectToAction("GetAll");
        }

        //###################################################################################


        //###################################################################################
        [Authorize]
        [HttpGet]
       
        public async Task<ActionResult> Details(int id)
        {
            if (ModelState.IsValid)
            {
                var model = await airline.GetSingleAirLine(id);
                return View(model);
            }

            return RedirectToAction("NotFound");
        }

        //##################   DETAILS  #######################
        [Authorize]
        [HttpPost]
        public ActionResult Details()
        {

            return RedirectToAction("GetAll");
        }

        //###################################################################################


        //#######################################  GET ALL ############################################
        [Authorize]
        [HttpGet]
     
        public async Task<ActionResult> GetAll()
        {
            var model = await airline.GetAllAirline();
            return View(model);
        }

        //###################################################################################

        //#######################################  GET ALL ############################################
        [Authorize]
        [HttpGet]
        
        public async Task<ActionResult> Edit(int  id)
        {
            if (ModelState.IsValid)
            {
                var model = await airline.GetSingleAirLine(id);
                return View(model);
            }

            return RedirectToAction("NotFound");
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Airline item)
        {
            if (ModelState.IsValid)
            {
                var model = await airline.UpdateAirLine(item);
                var res = await airline.Commit();
                TempData["Message"] = $"{model.Name} was successfully updated";
            }
            return RedirectToAction("GetAll");
        }

        //###################################################################################


        //###################################################################################
        [Authorize]
        [HttpGet]
  
        public async Task<ActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var model = await airline.GetSingleAirLine(id);

                TempData["Item"] = model;
                return View(model);
            }

            return RedirectToAction("NotFound");
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete( )
        {
            var model = (Airline)TempData["Item"];
            airline.RemoveAirline(model);
            var res = await airline.Commit();

            TempData["Message2"] = "Delete Successful";
            return RedirectToAction("GetAll");

        }

        //###################################################################################

        [HttpGet]
        public ActionResult NotFound()
        {
            return View();
        }
    }
}
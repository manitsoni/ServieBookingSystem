using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessEntities.ViewModel;
using Business.Interface;
using Business;
using Common;
namespace Service.Customer.Controllers
{
    public class BookServiceController : Controller
    {
        // GET: BookService
        IServiceBookingManager serviceBooking;
        public BookServiceController(IServiceBookingManager service)
        {
            serviceBooking = service;
        }
        public ActionResult Index()
        {
            int id = SessionProxyUser.UserID;
            ViewBag.Vehicles = new SelectList(serviceBooking.GetVehicals(id), "Id", "VehicalName");
            return View();
        }
        public JsonResult AddService(int? VehicalId,string ServiceName)
        {
            ServiceEntities se = new ServiceEntities();
            se.BookingDate = DateTime.Now;
            se.CompletedDate = DateTime.Now;
            se.IsActive = true;
            se.IsAssigned = false;
            se.IsBooked = true;
            se.IsCompleted = false;
            se.Price = 0;
            se.ServiceName = ServiceName;
            se.VehicalId = Convert.ToInt32(VehicalId);
            se.MechanicId = 4;
            se.UserId = SessionProxyUser.UserID;
            var ConfirmAdded = serviceBooking.AddServices(se);
            return Json(ConfirmAdded, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetServices()
        {
            int id = SessionProxyUser.UserID;
            return Json(serviceBooking.GetServices(id).ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
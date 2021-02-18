using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Admin.Interface;
using Business.Admin;
using BusinessEntities.Admin.ViewModel;
namespace Service.Admin.Controllers
{
    public class VehicalTypeController : Controller
    {
        private IVehicalTypeManager VehicalTypeManager;
        public VehicalTypeController(IVehicalTypeManager vehicalType)
        {
            VehicalTypeManager = vehicalType;
        }
        // GET: VehicalType
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddNewVehicalType()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddNewVehicalType(string Name)
        {
            VehicalTypeEntities vehicalTypeEntities = new VehicalTypeEntities();
            vehicalTypeEntities.VehicalType = Name;
            vehicalTypeEntities.isActive = true;
            var ConfirmationAdded = VehicalTypeManager.AddVehicalType(vehicalTypeEntities);
            return Json(ConfirmationAdded,JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetVehicalTypes()
        {
            var list = VehicalTypeManager.GetVehicalTypes().ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
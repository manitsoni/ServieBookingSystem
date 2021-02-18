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
    public class VehicalCompanyController : Controller
    {
        private IVehicalCompanyNameManager VehicalCompanyNameManager;
        public VehicalCompanyController(IVehicalCompanyNameManager vehicalCompanyName)
        {
            VehicalCompanyNameManager = vehicalCompanyName;
        }
        // GET: VehicalCompany
        public ActionResult Index()
        {
            ViewBag.TypeList = new SelectList(VehicalCompanyNameManager.GetVehicalTypeListForDDs(), "Id", "VehicalType");
            return View();
        }
        public JsonResult GetVehicalCompany()
        {
            var list = VehicalCompanyNameManager.GetVehicalCompanyies().ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AddNewVehicalCompany(string Name,int TypeId)
        {
            VCompanyEntities vehicalCompany = new VCompanyEntities();
            vehicalCompany.VehicalTypeId = TypeId;
            vehicalCompany.VehicalCompanyName = Name;
            vehicalCompany.isActive = true;
            vehicalCompany.CreatedDate = DateTime.Now;
            var ConfirmAdded = VehicalCompanyNameManager.AddVehicalCompanyName(vehicalCompany);
            return Json(ConfirmAdded, JsonRequestBehavior.AllowGet);
        }
    }
}
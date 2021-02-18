using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Admin.Interface;
using Business.Admin;
using BusinessEntities.Admin.ViewModel;
using BusinessEntities.ViewModel;
using Common;
using Business.Interface;
using Business;
namespace Service.Customer.Controllers
{
    public class VehicalController : Controller
    {
        isLogin UserLogin = new isLogin();
        private IVehicalManager vehicalManager;
        public VehicalController(IVehicalManager vehical)
        {
            vehicalManager = vehical;
        }
        public ActionResult Index()
        {
            if (UserLogin.IsUserLogin())
            {
                ViewBag.TypeList = new SelectList(vehicalManager.GetVehicalType(), "Id", "VehicalType");
                ViewBag.CompanyList = new SelectList("", "Id", "vehicalCompanyName");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Customer");
            }

        }
        public PartialViewResult _AddVehical()
        {
            return PartialView();
        }
        public JsonResult SelectCompanyByType(int TypeId)
        {
            return Json(vehicalManager.GetVehicalCompaniesByVehicalType(TypeId), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetVehicals()
        {
            return Json(vehicalManager.GetVehicalDetails().ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult AddNewVehical(int? TypeId,int CompanyId,string VehicalName,string OwnerName,string ChassisNo, string LicencePlateNo)
        {
            VehicalEntities vehical = new VehicalEntities();
            vehical.VehicalTypeId = TypeId;
            vehical.VehicalCompanyId = CompanyId;
            vehical.VehicalName = VehicalName;
            vehical.OwnerName = OwnerName;
            vehical.ChassisNo = ChassisNo;
            vehical.LicencePlateNo = LicencePlateNo;
            vehical.CreatedDate = DateTime.Now;
            vehical.UpdatedOn = DateTime.Now;
            vehical.isActive = true;
            vehical.RegistrationDate = DateTime.Now;
            vehical.UserId = SessionProxyUser.UserID;
            var ConfirmAdded = vehicalManager.AddVehical(vehical);
            return Json(ConfirmAdded, JsonRequestBehavior.AllowGet);
        }
    }
}
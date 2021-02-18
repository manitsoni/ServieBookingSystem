using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Admin.Interface;
using Business.Admin;
using BusinessEntities.Admin.ViewModel;
namespace Service.Dealer.Controllers
{
    public class ManageMechanicController : Controller
    {
        private IMechanicManager mechanicManager;
        public ManageMechanicController(IMechanicManager mechanic)
        {
            mechanicManager = mechanic;
        }
        // GET: ManageMechanic
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult AddMechanic(string MechanicName,string Email,string Password)
        {
            MechanicEntities me = new MechanicEntities();
            me.IsActive = true;
            me.MechanicName = MechanicName;
            me.Email = Email;
            me.Password = Password;
            me.IsActive = true;
            var ConfirmAdded = mechanicManager.AddMechanic(me);
            return Json(ConfirmAdded, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetMechanic()
        {
            return Json(mechanicManager.GetMechanics().ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
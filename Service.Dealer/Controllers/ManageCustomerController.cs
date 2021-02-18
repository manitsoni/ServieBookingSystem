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
    public class ManageCustomerController : Controller
    {
        private ICustomerManagerA customerManager;
        public ManageCustomerController(ICustomerManagerA customer)
        {
            customerManager = customer;
        }
        // GET: ManageCustomer
        public ActionResult Index()
        {
            ViewBag.CustomerList = customerManager.GetCustomers().ToList();
            return View();
        }

    }
}
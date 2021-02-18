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
    public class CustomerController : Controller
    {
        private ICustomerManager customerManager;
        public CustomerController(ICustomerManager customer)
        {
            customerManager = customer;
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(CustomerEntities customerEntities)
        {
            if (!ModelState.IsValid)
            {
                customerEntities.CreatedDate = DateTime.Now;
                customerEntities.UpdatetDate = DateTime.Now;
                customerEntities.isActive = true;
                bool val = customerManager.AddCustomer(customerEntities);
                if (val == true)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "User Already Exists!";
                    return View();
                }
               
            }
            else
            {
                return View();
            }
           
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username,string Password)
        {
            int UserId = customerManager.LoginUser(Username, Password);
            if (UserId == 0)
            {
                TempData["Message"] = "Invalid User";
                return View();
            }
            else
            {
               
                customerManager.BindToSession(UserId).ToList();
                return RedirectToAction("Index","Vehical");
            }
            
        }
    }
}
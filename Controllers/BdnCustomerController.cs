using Bdn_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bdn_Lesson04.Controllers
{
    public class BdnCustomerController : Controller
    {
        // GET: BdnCustomer
        public ActionResult Index()
        {
            return View();
            
        }
        // Action BdnCustomerDetail 
        public ActionResult BdnCustomerDetail()
        {
            // tao doi tuong du lieu 
            var customer = new BdnCustomer ()
            {

            }
            return View();
        }
        // action: BdnCustomerDetail
        public ActionResult BdnCustomerDetail()
        {
            var customer = new Bdncustomer()
            {
                CustomerId = 1,
                FirstName = "Bui Duc",
                Lastname = " Nguyen",
                Address = "K22CNT3",
                YearofBirth = 2004

            };
            ViewBag.customer = customer;
            return View();
        }

    public ActionResult BdnListCustomer()
        {
            var list = new List<BdnCustomer>()
            {
                new Bdncustomer(){
                CustomerId = 1,
                FirstName = "Bui Duc",
                Lastname = " Nguyen",
                Address = "K22CNT3",
                YearofBirth = 2004
                }
            };
        }
    }
}
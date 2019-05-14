using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using QuoteVMC.ViewModels;

namespace QuoteVMC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (QuoteEntities db = new QuoteEntities())
            {
                var customers = (from c in db.Customers select c).ToList();
                var customersVM = new List<AdminViewModel>();
                foreach (var customer in customers)
                {
                    var customerVM = new AdminViewModel();
                    customerVM.Id = customer.Id;
                    customerVM.FirstName = customer.FirstName;
                    customerVM.LastName = customer.LastName;
                    customerVM.EmailAddress = customer.EmailAddress;
                    customerVM.QuoteAmount = "$" + customer.QuoteAmount;
                    customersVM.Add(customerVM);
                }
                return View(customersVM);
            }
        }
    }
}
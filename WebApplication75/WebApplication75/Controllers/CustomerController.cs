using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication75.Models;
using WebApplication75.ViewModel;
using System.Data.Entity;
namespace WebApplication75.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context; //creating a dbcontext object using applicationdbcontext
        //the db context is a disposable object

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        //this  function below dispose of a db context,it overrides the base controller class
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        // GET: Customer
        public ActionResult Index()
        {
            //this is an example of eager loading,the include method is used to pass the target property 
            var customer = _context.Customers.Include(c=>c.MembershipType).ToList();//this line allows us to get all customer in the database
            //this customer property is a dbset which was defined in the db properties

            var ViewModel = new CustomerViewModel
            {
                GetCustomers = customer.ToList()
            };

            return View(ViewModel);
        }

        public ActionResult Detail(int id)
        {
            
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }


        public ActionResult New()
        {

            var membershipTypes = _context.MembershipTypes.ToList();

            var ViewModel = new NewCustomerViewModel
            {
                MembershipType = membershipTypes
            };

            return View(ViewModel);
        }

    }
}
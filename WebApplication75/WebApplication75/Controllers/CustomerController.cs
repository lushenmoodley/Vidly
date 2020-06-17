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

            if (User.IsInRole("CanManageMovies"))

                return View("Index", ViewModel);
            else

                return View("ReadOnlyList", ViewModel);

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

        [Authorize(Roles = "CanManageMovies")]
        public ActionResult New()//this method populates the drop down list
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var ViewModel = new NewCustomerViewModel
            {
                Customer = new Customer(),
                MembershipType = membershipTypes
            };

            return View("New", ViewModel);
        }

        [HttpPost]/*this ensure the method is only called using httpPost not httpGet*/
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "CanManageMovies")]
        public ActionResult Create(Customer customer)
        {
            if(ModelState.IsValid==false)
            {
                var ViewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    MembershipType = _context.MembershipTypes.ToList()
                };
                return View("New",ViewModel);
            }

            if (customer.CustomerId == 0)
            {
                _context.Customers.Add(customer);                
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.CustomerId == customer.CustomerId);
                customerInDb.CustomerName = customer.CustomerName;
                customerInDb.CustomerDateOfBirth = customer.CustomerDateOfBirth;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribed = customer.IsSubscribed;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }


        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId==id);

            if(customer==null)
            {
                return HttpNotFound();
            }

            var ViewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipType = _context.MembershipTypes.ToList()
            };
            return View("New",ViewModel);
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication75.Models;
using WebApplication75.DTO;
using AutoMapper;
using WebApplication75.App_Start;
namespace WebApplication75.Controllers
{
    public class CustomersController : ApiController //this class is derived from api controller
    {
        private ApplicationDbContext _context;//context object to the database

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //Get/api/Customers--this is a convention build into asp.net web api
        public IEnumerable<CustomerDTO> GetCustomers()//return a list of customers
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDTO>);
        }

        //Get/api/Customers/1
        public IHttpActionResult GetCustomer(int id)// this is action to get a single customer
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Customer,CustomerDTO>(customer));
        }

        //Post/api/customer
        [HttpPost]// this action will only work with a post method
        public IHttpActionResult PostCustomer(CustomerDTO customerDto)//this method will create a customer
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var customer = Mapper.Map<CustomerDTO, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.CustomerId = customer.CustomerId;

            return Created(new Uri(Request.RequestUri+"/"+customer.CustomerId),customerDto);
        }

        //Put/api/customers/1
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDTO customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.CustomerId == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(customerDto,customerInDb);
            customerInDb.CustomerName = customerDto.CustomerName;
            customerInDb.CustomerDateOfBirth = customerDto.CustomerDateOfBirth;
            customerInDb.IsSubscribed = customerDto.IsSubscribed;
            customerInDb.MembershipTypeId = customerDto.MembershipTypeId;

            _context.SaveChanges();
        }

        //Delete /api/Customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.CustomerId == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlamoCorp.Web.API.Data;
using AlamoCorp.Web.Core.Models.Core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlamoCorp.Web.API.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomersController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        [HttpPost("createcustomer")]
        public ActionResult<Customer> CreateCustomer([FromBody]Customer customer)
        {
            var CreatedCustomer = dbContext.Customers.Add(customer).Entity;
            dbContext.SaveChanges();
            return Ok(CreatedCustomer);
        }
        [HttpGet("getcustomers")]
        public ActionResult<Customer> GetCustomers()
        {
            var Customers = dbContext.Customers.ToList();
            return Ok(Customers);
        }
        [HttpGet("getcustomer/{customerID}")]
        public ActionResult<Customer> CreateCustomer(long customerID)
        {
            var Customer = dbContext.Customers.FirstOrDefault(opt => opt.CustomerID == customerID);
            return Ok(Customer);
        }
    }
}

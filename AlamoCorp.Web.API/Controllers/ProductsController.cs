using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AlamoCorp.Web.API.Data;
using AlamoCorp.Web.API.Services;
using AlamoCorp.Web.Core.Models.Core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlamoCorp.Web.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private ApplicationDbContext dbContext;
        public ProductsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        [HttpGet("GetProducts")]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var Products = dbContext.Products.ToList();
            return Ok(Products);
        }
        [HttpPost("AddProduct")]
        public ActionResult<IEnumerable<Product>> AddProduct([FromBody]Product product)
        {
            var UpdatedProducts = ProductService.AddProduct(dbContext, product);
            return Ok(UpdatedProducts);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlamoCorp.Web.API.Data;
using AlamoCorp.Web.API.Services;
using AlamoCorp.Web.Core.Models.Core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlamoCorp.Web.API.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private ApplicationDbContext dbContext;
        public OrdersController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        [HttpPost("createorder")]
        public ActionResult<Order> MakeOrder([FromBody] Order order)
        {
            var CreatedOrder = OrderService.CreateOrder(dbContext, order);
            return Ok(CreatedOrder);
        }
        [HttpGet("getorders")]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            var Orders = OrderService.GetOrders(dbContext);
            return Ok(Orders);
        }
        [HttpGet("getorder/{orderID}")]
        public ActionResult<Order> GetOrder(long orderID)
        {
            var Order = OrderService.GetOrder(dbContext, orderID);
            return Ok(Order);
        }
        [HttpPut("updateorderstatus/{orderID}")]
        public ActionResult<Order> UpdateOrderStatus(long orderID)
        {
            var UpdatedOrder = OrderService.UpdateOrder(dbContext, orderID);
            return Ok(UpdatedOrder);
        }
    }
}


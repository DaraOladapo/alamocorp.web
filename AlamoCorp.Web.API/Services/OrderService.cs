using AlamoCorp.Web.API.Data;
using AlamoCorp.Web.Core.Models.Core;
using AlamoCorp.Web.Core.Models.Enum;
using System.Collections.Generic;
using System.Linq;

namespace AlamoCorp.Web.API.Services
{
    public class OrderService
    {
        public static Order CreateOrder(ApplicationDbContext dbContext, Order order)
        {
            var orderCustomer = dbContext.Customers.FirstOrDefault(opt => opt.EmailAddress == order.Customer.EmailAddress && opt.FullName == order.Customer.EmailAddress && opt.PhoneNumber == order.Customer.PhoneNumber);
            if (orderCustomer == null)
            {
                dbContext.Customers.Add(order.Customer);
                dbContext.SaveChanges();
            }

            Order CreatedOrder = dbContext.Orders.Add(order).Entity;
            dbContext.SaveChanges();
            return CreatedOrder;
        }
        public static IEnumerable<Order> GetOrders(ApplicationDbContext dbContext)
        {
            var Orders = dbContext.Orders.ToList();
            return Orders;
        }
        public static Order GetOrder(ApplicationDbContext dbContext, long OrderID)
        {
            Order Order = dbContext.Orders.FirstOrDefault(opt => opt.OrderID == OrderID);
            return Order;
        }

        internal static Order UpdateOrder(ApplicationDbContext dbContext, long orderID)
        {
            var Order = dbContext.Orders.FirstOrDefault(opt => opt.OrderID == orderID);
            if (Order != null)
            {

                switch (Order.DeliveryStatus)
                {
                    case DeliveryStatus.New:
                        Order.DeliveryStatus = DeliveryStatus.Processing;
                        break;
                    case DeliveryStatus.Processing:
                        Order.DeliveryStatus = DeliveryStatus.Confirmed;
                        break;
                    case DeliveryStatus.Confirmed:
                        Order.DeliveryStatus = DeliveryStatus.Dispatched;
                        break;
                    case DeliveryStatus.Dispatched:
                        Order.DeliveryStatus = DeliveryStatus.Shipped;
                        break;
                    case DeliveryStatus.Shipped:
                        Order.DeliveryStatus = DeliveryStatus.Delivered;
                        break;
                    case DeliveryStatus.Delivered:
                        Order.DeliveryStatus = DeliveryStatus.Delivered;
                        break;
                    default:
                        Order.DeliveryStatus = DeliveryStatus.New;
                        break;
                }
                return Order;
            }
            else
            {
                return null;
            }
        }
    }
}

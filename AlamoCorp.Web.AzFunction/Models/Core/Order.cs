using AlamoCorp.Web.AzFunction.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlamoCorp.Web.AzFunction.Models.Core
{
    public class Order
    {
        public long OrderID { get; set; }
        public DateTime CreatedDate { get; set; }
        public Customer Customer { get; set; }
        public List<CartLineItems> LineItems { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }

    }
}

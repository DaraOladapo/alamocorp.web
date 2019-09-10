using AlamoCorp.Web.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlamoCorp.Web.Core.Models.Core
{
    public class Order
    {
        [Key]
        public long ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public Customer Customer { get; set; }
        public List<Product> LineItems { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }

    }
}

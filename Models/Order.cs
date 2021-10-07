using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoesPizza.Models
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }

        [Key]

        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual List<OrderDetails> OrderDetails { get; set; }

    }
}

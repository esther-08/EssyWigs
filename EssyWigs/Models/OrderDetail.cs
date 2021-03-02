using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class OrderDetail
    {
        public OrderDetail()
        {
        }

        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int ProductOrderId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public ProductOrder ProductOrder { get; set; }
    }
}

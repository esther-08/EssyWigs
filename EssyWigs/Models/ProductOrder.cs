using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EssyWigs.Models
{
    public class ProductOrder
    {
        public ProductOrder()
        {
        }

        public ProductOrder(string firstName, string lastName, long paymentCardNo, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PaymentCardNo = paymentCardNo;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public int ProductOrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PaymentCardNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public DateTime ProductOrderPlaced { get; internal set; }
    }

}

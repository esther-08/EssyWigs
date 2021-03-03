using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [StringLength(50)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Second Name")]
        public string LastName { get; set; }
        [Required]
        [CreditCard]
        [Display(Name = "Credit Card")]
        public long PaymentCardNo { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public DateTime ProductOrderPlaced { get; internal set; }
    }

}

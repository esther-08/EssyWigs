using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class Customer: Stakeholder
    {
        public Customer(string firstName, string lastName, long paymentCardNo, string email, string phoneNumber) : base(email, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PaymentCardNo = paymentCardNo;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PaymentCardNo { get; set; }
    }

}

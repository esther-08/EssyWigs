using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.Models
{
    public class Stakeholder
    {
        public Stakeholder(string email, string phoneNumber)
        {
            Email = email; 
            PhoneNumber = phoneNumber;
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

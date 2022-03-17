using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPTracker1p1.Controllers;

namespace CPTracker1p1.Models
{
    public class CreateContact : AddressBookController
    {
        public CreateContact(Microsoft.Extensions.Configuration.IConfiguration configuration, Microsoft.AspNetCore.Hosting.IWebHostEnvironment env) : base(configuration, env)
        {
        }

        public int cId { get; set; }
        public string cFirstName { get; set; }
        public string cLastName { get; set; }
        public string cAddress { get; set; }
        public string cEmailId { get; set; }
        public string cContactNo { get; set; }
        public string cCompany { get; set; }
    }
}

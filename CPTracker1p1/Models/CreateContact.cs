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

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string Company { get; set; }
    }
}

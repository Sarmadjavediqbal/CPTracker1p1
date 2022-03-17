using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using CPTracker1p1.Models;
using Microsoft.Data.SqlClient;

namespace CPTracker1p1.Controllers
{
    [Authorize]
    public class AddressBookController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment env;
        private IConfiguration _configuration;
        private IWebHostEnvironment _env;
        private SqlDataReader myReader;

        // GET: AddressBookController
        public ActionResult Contact()
        {
            return View();
        }

        //GET: CreateContactForm/Create
        public IActionResult CreateContactForm()
        {
            return View();
        }

        public AddressBookController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;

        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"Select FirstName, LastName, cAddress, EmailId, ContactNo, Company from dbo.AddressBook";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AddressBookAppCon");
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

                return new JsonResult(table);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Post(AddressBook Contact)
        {
            string query = @"insert into dbo.AddressBook(FirstName,LastName,cAddress,EmailId,ContactNo,Company)
                            values
                                (
                                    '" + Contact.FirstName + @"',
                                    '" + Contact.LastName + @"',
                                    '" + Contact.Address + @"',
                                    '" + Contact.EmailId + @"',
                                    '" + Contact.ContactNo + @"',
                                    '" + Contact.Company + @"',
                                )";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AddressBookAppCon");
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(AddressBook Contact)
        {
            string query = @"update dbo.AddressBook set 
                                FirstName = '" + Contact.FirstName + @"',
                                LastName = '" + Contact.LastName + @"', 
                                cAddress = '" + Contact.Address + @"', 
                                EmailId = '" + Contact.EmailId + @"', 
    `                           ContactNo = '" + Contact.ContactNo + @"', 
                                Company = '" + Contact.Company + @"'";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AddressBookAppCon");
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult("Updated SuccessFully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int Id)
        {
            string query = @"Delete from dbo.AddressBook where Id = " + Id +@"
                            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("AddressBookAppCon");
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult("Deleted Successfully");
        }


        /*// GET: AddressBookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        // GET: AddressBookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressBookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddressBookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddressBookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddressBookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddressBookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}

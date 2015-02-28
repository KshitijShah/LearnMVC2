﻿using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            CustomerData custData = new CustomerData();
            custData.Id = 1001;
            custData.CustomerCode = "2004";
            custData.Amount = 1115.60;

            return View("Customer",custData);
        }
    }
}
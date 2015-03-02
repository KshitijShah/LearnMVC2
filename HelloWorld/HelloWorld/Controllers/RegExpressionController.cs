using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace HelloWorld.Controllers
{
    public class RegExpressionController : Controller
    {
        // GET: RegExpression
        public ActionResult Index(RegExpData regData)
        {
            //if (regData.StringToValidate != null && regData.RegularExprssion != null)
            //{
            //    if (Regex.IsMatch(regData.StringToValidate, regData.RegularExprssion))
            //    {
            //        regData.ValidationResult = "Kshitij";
            //    }

            //    else
            //    {
            //        regData.ValidationResult = "Shah";
            //    }
            //}

            return View("RegExpValidator", regData);
        }

        public ActionResult Validate(RegExpData regData)
        {

            return View("RegExpValidator");
        }
    }
}
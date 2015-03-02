using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace HelloWorld.Models
{
    public class RegExpData
    {

        public string StringToValidate { set; get; }
        public string RegularExprssion { set; get; }
        public string ValidationResult
        {

            
            get
            {
                if (StringToValidate != null && RegularExprssion != null)
                    return (Regex.IsMatch(StringToValidate.ToLower(), RegularExprssion) ? "Pass" : "Failed");

                return "Failed";
            }

            //set
            //{

            //}

        }
    }
}
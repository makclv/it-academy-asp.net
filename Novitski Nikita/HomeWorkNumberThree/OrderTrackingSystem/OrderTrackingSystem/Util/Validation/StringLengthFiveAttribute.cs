using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrderTrackingSystem.Util.Validation
{
    public class StringLengthFiveAttribute : ValidationAttribute
    {
       
        public override bool IsValid(object value)
        {

            return value is string && (value.ToString().Length >= 15);
        }
    }
}
using OrderTrackingSystem.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrderTrackingSystem.Util.Validation
{
   
    //public class UniquEmailAttribute : ValidationAttribute
    //{

    //    public override bool IsValid(object value)
    //    {
    //        var email = CollectionEmail.AllEmail();

    //        if (value is string && email.Any(c=>c != (string)value))
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //}

    public static class CollectionEmail
    {
        public static List<string> AllEmail()
        {
            return new List<string> { "11111@mail.ru", "22222@mail.ru", "33333@mail.ru", "44444@mail.ru" }; 
        }
    }

}
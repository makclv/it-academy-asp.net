﻿using System.Web;
using System.Web.Mvc;

namespace ItAcademy.Hw.Users.Client
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

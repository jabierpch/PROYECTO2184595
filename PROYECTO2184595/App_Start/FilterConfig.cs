﻿using System.Web;
using System.Web.Mvc;

namespace PROYECTO2184595
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

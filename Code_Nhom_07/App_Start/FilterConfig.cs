﻿using System.Web;
using System.Web.Mvc;

namespace Code_Nhom_07
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
﻿using System.Web;
using System.Web.Mvc;

namespace Comp2007_S2016_Lab4 {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

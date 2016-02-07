using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelPopUpAjaxToolKitApp
{
    public class Helper
    {
        public static string  ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["ModelPopUP"].ConnectionString;
            }
        }
    }
}
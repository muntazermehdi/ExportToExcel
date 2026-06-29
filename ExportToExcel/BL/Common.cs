using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ExportToExcel.BL
{
    public static class Common
    {
        public static string LogFilePath
        {
            get
            {
                return ConfigurationManager.AppSettings["LogFilePath"].ToString();
            }
        }
    }
}

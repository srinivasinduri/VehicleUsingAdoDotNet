using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleUsingAdoDotNet
{
    class Helper
    {
        public static string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["VehicleDemoDB"].ConnectionString;
            }
        }
    }
}

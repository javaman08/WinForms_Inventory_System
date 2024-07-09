using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY_SYSTEM
{
    public static class AppConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["InventoryConn"].ConnectionString;
    }
}

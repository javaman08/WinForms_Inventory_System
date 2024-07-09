using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CONNECTIVITY
{
    internal class DBConn
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-OBES7KSE\SQLEXPRESS;Initial Catalog=INVENTORY_DB;Integrated Security=True;Trust Server Certificate=True");
    }
}

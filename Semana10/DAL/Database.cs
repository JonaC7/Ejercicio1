using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana10.Properties;
using System.Configuration;
using System.Data.SqlClient;

namespace Semana10.DAL
{
    public class Database
    {
        public static string getStrConnection()
        {
            return Settings.Default.empleadosConnectionString;
        }

        public SqlConnection GetConnection()
        {
           SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;
        }

    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganic
{
    public static class DatabaseConfig
    {
        
        public static string ConnectionString = @"Data Source=DESKTOP-HBDVMFC;Initial Catalog=GreenLifeOrganicDB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}

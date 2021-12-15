using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WeddingPlanner.Helpers
{
    public class DbHelpers
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Assignment2;");
        }
    }
}

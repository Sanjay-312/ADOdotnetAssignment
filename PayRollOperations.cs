using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOdotNetAssignment
{
    public class PayRollOperations
    {
        public static void create_database()
        {
            SqlConnection connection = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=master;integrated security=true");
            string query = @"create database PAY_ROLL_SERVICE";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("-----------------");
            Console.WriteLine("database created successfully");
            connection.Close();
        }

        
        
    }
}

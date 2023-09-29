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
        public static SqlConnection connection = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=PAY_ROLL_SERVICE; integrated security=true");

        public static void create_table()
        {
            string query = @"create table EMPLOYEE_PAY_ROLL(EMP_ID int primary key identity(1,1),EMP_NAME varchar(20),PHONE_NUM bigint,CITY varchar(20),SALARY int,START_DATE date)";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            Console.WriteLine("--------------------------");
            Console.WriteLine("table created successfully");
            connection.Close();

        }



    }
}

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
        public static void insert_data()
        {
            string query = @"insert into EMPLOYEE_PAY_ROLL values('Pavan',9456185698,'Mumbai',20000,'2021-09-15'), 
                                                         ('Kumar',9256489563,'Chennai',25000,'2020-09-15'),
                                                         ('Sanjay',8561564895,'Pune',28000,'2019-09-15'),
                                                         ('Chandu',9648956987,'Hyderabad',35000,'2021-05-5'),
                                                         ('Vamsi',1265489565,'Kochi',18000,'2022-08-03'),
                                                         ('Raghava',8956478596,'Kerala',42000,'2021-12-13')";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("---------------------------");
            Console.WriteLine("data inserted successfully");
            connection.Close();
        }
        public static void update_data()
        {
            string query = @"update EMPLOYEE_PAY_ROLL set SALARY=3000000 where EMP_NAME='Teresa'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("--------------------");
            Console.WriteLine("data updated successfully");
            connection.Close();
        }



    }
}

using System;
using System.Data.SqlClient;

namespace dbquery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");

            string connectionString = null;
            connectionString = @"Data Source=SQL205\PSQL205;Initial Catalog=KETL_Tester;User ID=TesterFullAccess;Password=Tester2Full!;Connection Timeout=60;";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                Console.WriteLine("Opening Connection ...");
                conn.Open();

                Console.WriteLine("Connection successful!");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}

using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DB Example");

            String connectionString = "DATA SOURCE = XE; PASSWORD=abc123; USER ID = HR;";

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();
            Console.WriteLine("Connection is opened");

            OracleCommand query = new OracleCommand();
            String employeeId = "105";
            query.CommandText = "SELECT LAST_NAME FROM EMPLOYEES WHERE EMPLOYEE_ID = " + employeeId;
            

            query.Connection = con;
            query.CommandType = CommandType.Text;
            

            OracleDataReader dr = query.ExecuteReader();
            dr.Read();
            Console.WriteLine("dr.Read() is done");

            String result;
            result = dr.GetString(0);

            Console.WriteLine("The result of query is: " + result);

            con.Close();

            Console.WriteLine("End of program. Good Bye");






        }
    }
}

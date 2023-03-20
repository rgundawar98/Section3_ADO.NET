using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETProblems
{
    public class EmployeeRepo
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Payroll_Service_Database;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void GetAllEmployee()
        {
            try
            {
                EmployeeModel model = new EmployeeModel();
                using(this.connection)
                {
                    string query = @"select EmployeeId ,EmpName,Phone,Address,Department,Gender,BasicPay,Deduction,Taxablepay,IncomeTax,NetPay,StartDate,City,Country from EmployeeDetails";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.EmployeeId = reader.GetInt32(0);
                            model.EmpName = reader.GetString(1);
                            model.Phone = reader.GetString(2);
                            model.Address = reader.GetString(3);
                            model.Department = reader.GetString(4);
                            model.Gender = Convert.ToChar(reader.GetString(5));
                            model.BasicPay = reader.GetDouble(6);
                            model.Deduction = reader.GetDouble(7);
                            model.TaxablePay = reader.GetDouble(8);
                            model.IncomeTax = reader.GetDouble(9);
                            model.NetPay = reader.GetDouble(10);
                            model.startDate = reader.GetDateTime(11);
                            model.city = reader.GetString(12);
                            model.country = reader.GetString(13);
                            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13}", model.EmployeeId, model.EmpName,
                                model.Phone, model.Address, model.Department, model.Gender, model.BasicPay, model.Deduction, model.TaxablePay, model.IncomeTax,
                                model.NetPay, model.startDate, model.city, model.country);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data not found");
                    }
                    reader.Close();
                    this.connection.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}

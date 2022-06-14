using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityManager;


namespace DataManager
{
    public class EmpDataManager:IEmpDataManager
    {
        public List<Employee> GetAllEmployee()
        {
            string connectionString = @"Data Source=.;Initial Catalog=empdb;Integrated Security=True";
            using (IDbConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionString;
                using (IDbCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    string query = "exec ReadEmp";
                    cmd.CommandText = query;
                    List<Employee> employees = new List<Employee>();

                    try
                    {
                        con.Open();
                        IDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Name = reader["name"].ToString(),
                                Dept = reader["dept"].ToString(),
                                Salary = double.Parse(reader["salary"].ToString())
                            };
                            employees.Add(employee);
                        }
                        reader.Close();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                    return employees;
                }     
            }
        }
    }
}

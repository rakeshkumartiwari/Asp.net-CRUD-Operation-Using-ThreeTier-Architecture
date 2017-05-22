using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BLL;
namespace DAL
{
    public class EmployeeSqlRepository
    {
        private const string connectionString = @"Data source=.\SQLEXPRESS;Initial Catalog=EmployeeDb;Integrated Security=true";
        public void SaveEmployee(Employee employee)
        {
            using (var objConnection = new SqlConnection(connectionString))
            {
                objConnection.Open();
                var objCommand = new SqlCommand("sp_Employee", objConnection);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@Action", "Insert");
                objCommand.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                objCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
                objCommand.Parameters.AddWithValue("@LastName", employee.LastName);
                objCommand.Parameters.AddWithValue("@Designation", employee.Designation);
                objCommand.Parameters.AddWithValue("@DateOfJoining", employee.DateOfJoining);
                objCommand.Parameters.AddWithValue("@Gender", employee.Gender);
                objCommand.Parameters.AddWithValue("@Qualification", employee.Qualification);
                objCommand.Parameters.AddWithValue("@State", employee.State);
                objCommand.ExecuteNonQuery();

            }
        }
        public DataSet GetEmployee(string employeeId)
        {
            using (var objConnection = new SqlConnection(connectionString))
            {
                objConnection.Open();
                var objCommand = new SqlCommand("sp_Employee", objConnection);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@Action", "GetEmp");
                objCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
                var objDataSet = new DataSet();
                var objDataAdapter = new SqlDataAdapter(objCommand);
                objDataAdapter.Fill(objDataSet);
                return objDataSet;

            }
        }
        public DataSet GetAllEmployees()
        {
            using (var objConnection = new SqlConnection(connectionString))
            {
                objConnection.Open();
                var objCommand = new SqlCommand("sp_Employee", objConnection);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@Action", "GetAllEmp");
                var objDataSet = new DataSet();
                var objDataAdapter = new SqlDataAdapter(objCommand);
                objDataAdapter.Fill(objDataSet);
                return objDataSet;

            }
        }
        public void UpdateEmployee(Employee employee)
        {
            using (var objConnection = new SqlConnection(connectionString))
            {
                objConnection.Open();
                var objCommand = new SqlCommand("sp_Employee", objConnection);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@Action", "Update");
                objCommand.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                objCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
                objCommand.Parameters.AddWithValue("@LastName", employee.LastName);
                objCommand.Parameters.AddWithValue("@Designation", employee.Designation);
                objCommand.Parameters.AddWithValue("@DateOfJoining", employee.DateOfJoining);
                objCommand.Parameters.AddWithValue("@Gender", employee.Gender);
                objCommand.Parameters.AddWithValue("@Qualification", employee.Qualification);
                objCommand.Parameters.AddWithValue("@State", employee.State);
                objCommand.ExecuteNonQuery();

            }
        }
        public void DeleteEmployee(string employeeId)
        {
            using (var objConnection = new SqlConnection(connectionString))
            {
                objConnection.Open();
                var objCommand = new SqlCommand("sp_Employee", objConnection);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@Action", "Delete");
                objCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
                objCommand.ExecuteNonQuery();

            }
        }
    }
}

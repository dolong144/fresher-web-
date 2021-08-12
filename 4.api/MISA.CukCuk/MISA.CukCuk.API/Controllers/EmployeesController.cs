using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.CukCuk.API.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            //truy cập vào database 
            //Khai báo thông tin database
            var connectionString = "Host = 47.241.69.179;" +
                "Database = MISA.CukCuk_Demo_NVMANH;" +
                "User Id = dev;" +
                "Password = 12345678";

            //Khởi tạo đới tượng kết nối với database
            IDbConnection dbConnection = new MySqlConnection(connectionString);

            //Lấy dữu liệu
            var sqlCommand = "SELECT * FROM Employee";
            var employees = dbConnection.Query<Employee>(sqlCommand);

            //Trả về cho client
            var response = StatusCode(200, employees);
            return Ok(response);
        }

        [HttpGet("{employeeId}")]
        public IActionResult GetById(Guid employeeId)
        {
            //truy cập vào database 
            //Khai báo thông tin database
            var connectionString = "Host = 47.241.69.179;" +
                "Database = MISA.CukCuk_Demo_NVMANH;" +
                "User Id = dev;" +
                "Password = 12345678";

            //Khởi tạo đới tượng kết nối với database
            IDbConnection dbConnection = new MySqlConnection(connectionString);

            //Lấy dữu liệu
            var sqlCommand = $"SELECT * FROM Employee WHERE EmployeeId = @EmployeeIdParam";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@EmployeeIdParam", employeeId);
            var employee = dbConnection.QueryFirstOrDefault<Employee>(sqlCommand, param: parameters);

            //Trả về cho client
            var response = StatusCode(200, employee);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult InsertEmployee(Employee employee)
        {
            //truy cập vào database 
            //Khai báo thông tin database
            var connectionString = "Host = 47.241.69.179;" +
                "Database = MISA.CukCuk_Demo_NVMANH;" +
                "User Id = dev;" +
                "Password = 12345678";

            //Khởi tạo đới tượng kết nối với database
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            // khai báo dynamic param
            var dynamicParam = new DynamicParameters();


            //Thêm dữu liệu vào database
            var columnsName = string.Empty;
            var columnsParam = string.Empty;

            //Đọc từng property của object:
            var properties = employee.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                //lấy tên prop
                var propName = prop.Name;

                //lấy value của prop
                var propvalue = prop.GetValue(employee);

                // lấy kiểu dữ liệu của prop
                var propType = prop.PropertyType;

                //Thêm param tương ứng với prop
                dynamicParam.Add($"@{propName}", propvalue);

                columnsName += $"{propName},";
                columnsParam += $"@{propName},";
            }
            columnsName = columnsName.Remove(columnsName.Length - 1, 1);
            columnsParam = columnsParam.Remove(columnsParam.Length - 1, 1);
            var sqlCommand = $"INSERT INTO Employee({columnsName}) VALUES({columnsParam})";

            var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);

            //Trả về cho client
            var response = StatusCode(200, rowEffects);
            return Ok(response);
        }
        [HttpPut("{employeeId}")]
        public IActionResult ModifyEmployee(Guid employeeId, Employee employee)
        {
            //truy cập vào database 
            //Khai báo thông tin database
            var connectionString = "Host = 47.241.69.179;" +
                "Database = MISA.CukCuk_Demo_NVMANH;" +
                "User Id = dev;" +
                "Password = 12345678";

            //Khởi tạo đới tượng kết nối với database
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            // khai báo dynamic param
            var dynamicParam = new DynamicParameters();


            //Sửa dữ liệu database
            var columnsName = string.Empty;
            var columnsParam = string.Empty;

            //Đọc từng property của object:
            var properties = employee.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                //lấy tên prop
                var propName = prop.Name;

                //lấy value của prop
                var propvalue = prop.GetValue(employee);

                // lấy kiểu dữ liệu của prop
                var propType = prop.PropertyType;

                //Thêm param tương ứng với prop
                dynamicParam.Add($"@{propName}", propvalue);

                columnsName += $"{propName} = @{propName},";
                //columnsParam += $"@{propName},";
            }
            columnsName = columnsName.Remove(columnsName.Length - 1, 1);
            dynamicParam.Add($"@EmployeeIdToModify", employeeId);
            //columnsParam = columnsParam.Remove(columnsParam.Length - 1, 1);

            // truy vấn sửa dữ liệu
            var sqlCommand = $"UPDATE Employee SET {columnsName} WHERE EmployeeID = @EmployeeIdToModify";

            var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);

            //Trả về cho client
            var response = StatusCode(200, rowEffects);
            return Ok(response);
        }
        [HttpDelete("{employeeId}")]
        public IActionResult DeleteById(Guid employeeId)
        {
            //truy cập vào database 
            //Khai báo thông tin database
            var connectionString = "Host = 47.241.69.179;" +
                "Database = MISA.CukCuk_Demo_NVMANH;" +
                "User Id = dev;" +
                "Password = 12345678";

            //Khởi tạo đới tượng kết nối với database
            IDbConnection dbConnection = new MySqlConnection(connectionString);

            //Xoá dữu liệu
            var sqlCommand = $"DELETE FROM Employee WHERE EmployeeId = @EmployeeId";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@EmployeeId", employeeId);
            var rowEffects = dbConnection.Execute(sqlCommand, param: parameters);

            //Trả về cho client
            var response = StatusCode(200, rowEffects);
            return Ok(response);
        }
    }
}

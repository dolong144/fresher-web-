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
    public class DepartmentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDepartments()
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
            var sqlCommand = "SELECT * FROM Department";
            var departments = dbConnection.Query<Department>(sqlCommand);

            //Trả về cho client
            var response = StatusCode(200, departments);
            return Ok(response);
        }

        [HttpGet("{departmentId}")]
        public IActionResult GetById(Guid departmentId)
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
            var sqlCommand = $"SELECT * FROM Department WHERE departmentId = @DepartmentIdParam";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@DepartmentIdParam", departmentId);
            var department = dbConnection.QueryFirstOrDefault<Department>(sqlCommand, param: parameters);

            //Trả về cho client
            var response = StatusCode(200, department);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult Insertdepartment(Department department)
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
            var properties = department.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                //lấy tên prop
                var propName = prop.Name;

                //lấy value của prop
                var propvalue = prop.GetValue(department);

                // lấy kiểu dữ liệu của prop
                var propType = prop.PropertyType;

                //Thêm param tương ứng với prop
                dynamicParam.Add($"@{propName}", propvalue);

                columnsName += $"{propName},";
                columnsParam += $"@{propName},";
            }
            columnsName = columnsName.Remove(columnsName.Length - 1, 1);
            columnsParam = columnsParam.Remove(columnsParam.Length - 1, 1);
            var sqlCommand = $"INSERT INTO Department({columnsName}) VALUES({columnsParam})";

            var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);

            //Trả về cho client
            var response = StatusCode(200, rowEffects);
            return Ok(response);
        }
        [HttpPut("{departmentId}")]
        public IActionResult Modifydepartment(Guid departmentId, Department department)
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
            var properties = department.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                //lấy tên prop
                var propName = prop.Name;

                //lấy value của prop
                var propvalue = prop.GetValue(department);

                // lấy kiểu dữ liệu của prop
                var propType = prop.PropertyType;

                //Thêm param tương ứng với prop
                dynamicParam.Add($"@{propName}", propvalue);

                columnsName += $"{propName} = @{propName},";
                //columnsParam += $"@{propName},";
            }
            columnsName = columnsName.Remove(columnsName.Length - 1, 1);
            dynamicParam.Add($"@DepartmentIdToModify", departmentId);
            //columnsParam = columnsParam.Remove(columnsParam.Length - 1, 1);

            // truy vấn sửa dữ liệu
            var sqlCommand = $"UPDATE Department SET {columnsName} WHERE departmentID = @DepartmentIdToModify";

            var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);

            //Trả về cho client
            var response = StatusCode(200, rowEffects);
            return Ok(response);
        }
        [HttpDelete("{departmentId}")]
        public IActionResult DeleteById(Guid departmentId)
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
            var sqlCommand = $"DELETE FROM Department WHERE DepartmentId = @DepartmentId";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@DepartmentId", departmentId);
            var rowEffects = dbConnection.Execute(sqlCommand, param: parameters);

            //Trả về cho client
            var response = StatusCode(200, rowEffects);
            return Ok(response);
        }
    }
}

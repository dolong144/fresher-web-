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
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        /// <summary>
        /// lấy toàn bộ dữ liệu
        /// dvlong (12/8/2021)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCustomers()
        {
            try
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
                var sqlCommand = "SELECT * FROM Customer";
                var customers = dbConnection.Query<Customer>(sqlCommand);

                //Trả về cho client
                if (customers.Count() == 0)
                {
                    var response = StatusCode(204, customers);
                    return Ok(response);
                }
                else
                {
                    var response = StatusCode(200, customers);
                    return Ok(response);
                }
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.errorServe,
                    devMsg = e.Message,
                    errorCode = "ms_001",

                };
                var response = StatusCode(500, errorObject);
                return response;

            }
        }
        /// <summary>
        /// Lấy thông tin theo id
        /// dvlong(12/8/2021)
        /// </summary>
        /// <param name="customerId"> id của đối tượng cần lấy</param>
        /// <returns></returns>
        [HttpGet("{customerId}")]
        public IActionResult GetById(Guid customerId)
        {
            try
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
                var sqlCommand = $"SELECT * FROM Customer WHERE CustomerId = @CustomerIdParam";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CustomerIdParam", customerId);
                var customer = dbConnection.QueryFirstOrDefault<Customer>(sqlCommand, param: parameters);

                //Trả về cho client
                if(customer == null )
                {
                    return StatusCode(204);
                   
                }
                else
                {
                    var response = StatusCode(200, customer);
                    return Ok(response);
                }
                
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.errorServe,
                    devMsg = e.Message,
                    errorCode = "ms_001",

                };
                var response = StatusCode(500, errorObject);
                return response;
            }
        }
        /// <summary>
        /// thêm mới 1 đối tượng
        /// dvlong(12/8/2021)
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult InsertCustomer(Customer customer)
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
            var properties = customer.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                //lấy tên prop
                var propName = prop.Name;

                //lấy value của prop
                var propvalue = prop.GetValue(customer);

                // lấy kiểu dữ liệu của prop
                var propType = prop.PropertyType;

                //Thêm param tương ứng với prop
                dynamicParam.Add($"@{propName}", propvalue);

                columnsName += $"{propName},";
                columnsParam += $"@{propName},";
            }
            columnsName = columnsName.Remove(columnsName.Length - 1, 1);
            columnsParam = columnsParam.Remove(columnsParam.Length - 1, 1);
            // kiểm tra dữ liệu

            //kiểm tra id
           
            try
            {
                var sqlCommand = $"SELECT * FROM Customer WHERE CustomerId = @CustomerId";
                DynamicParameters parameters = new DynamicParameters();
                var checkId = dbConnection.QueryFirstOrDefault(sqlCommand, param: dynamicParam);
                if(checkId is not null)
                {
                    var errorObject = new
                    {
                        userMsg = Properties.Resource.errorDoubleId,
                        devMsg = Properties.Resource.errorDoubleId,
                        errorCode = "ms_004",

                    };
                    var response = StatusCode(400, errorObject);
                    return response;
                }
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.errorServe,
                    devMsg = e.Message,
                    errorCode = "ms_001",

                };
                var response = StatusCode(500, errorObject);
                return response;

            }

            // kiểm tra mã 
            //kiểm tra rỗng
            if(customer.CustomerCode == "" || customer.CustomerCode == null)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.nullCode,
                    devMsg = Properties.Resource.nullCode,
                    errorCode = "ms_003",

                };
                var response = StatusCode(400, errorObject);
                return response;
            }
            //kiểm tra trùng
            try
            {
                var sqlCommand = $"SELECT * FROM Customer WHERE CustomerCode = @CustomerCode";
                DynamicParameters parameters = new DynamicParameters();
                var checkCode = dbConnection.QueryFirstOrDefault(sqlCommand, param: dynamicParam);
                if (checkCode is not null)
                {
                    var errorObject = new
                    {
                        userMsg = Properties.Resource.errorDoubleCode,
                        devMsg = Properties.Resource.errorDoubleCode,
                        errorCode = "ms_002",

                    };
                    var response = StatusCode(400, errorObject);
                    return response;
                }
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.errorServe,
                    devMsg = e.Message,
                    errorCode = "ms_001",

                };
                var response = StatusCode(500, errorObject);
                return response;

            }


            try
            {
                
                var sqlCommand = $"INSERT INTO Customer({columnsName}) VALUES({columnsParam})";

                var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);

                //Trả về cho client
                if(rowEffects > 0) {

                    return StatusCode(201);
                    
                }
                else
                {
                    return StatusCode(400);
                } 
                
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.errorServe,
                    devMsg = e.Message,
                    errorCode = "ms_001",

                };
                var response = StatusCode(500, errorObject);
                return response;
            }
        }
        /// <summary>
        /// Sửa 1 đối tượng đã có
        /// dvlong(12/8/2021)
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPut("{customerId}")]
        public IActionResult ModifyCustomer(Guid customerId, Customer customer)
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
            var properties = customer.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                //lấy tên prop
                var propName = prop.Name;

                //lấy value của prop
                var propvalue = prop.GetValue(customer);

                // lấy kiểu dữ liệu của prop
                var propType = prop.PropertyType;

                //Thêm param tương ứng với prop
                dynamicParam.Add($"@{propName}", propvalue);

                columnsName += $"{propName} = @{propName},";
                //columnsParam += $"@{propName},";
            }
            columnsName = columnsName.Remove(columnsName.Length - 1, 1);
            dynamicParam.Add($"@CustomerIdToModify", customerId);

            // kiểm tra mã 
            //kiểm tra rỗng
            if (customer.CustomerCode == "" || customer.CustomerCode == null)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.nullCode,
                    devMsg = Properties.Resource.nullCode,
                    errorCode = "ms_003",

                };
                var response = StatusCode(400, errorObject);
                return response;
            }
            //kiểm tra trùng
            try
            {
                var sqlCommand = $"SELECT * FROM Customer WHERE CustomerCode = @CustomerCode";
                DynamicParameters parameters = new DynamicParameters();
                var checkCode = dbConnection.QueryFirstOrDefault(sqlCommand, param: dynamicParam);
                if (checkCode is not null)
                {
                    var errorObject = new
                    {
                        userMsg = Properties.Resource.errorDoubleCode,
                        devMsg = Properties.Resource.errorDoubleCode,
                        errorCode = "ms_002",

                    };
                    var response = StatusCode(400, errorObject);
                    return response;
                }
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.errorServe,
                    devMsg = e.Message,
                    errorCode = "ms_001",

                };
                var response = StatusCode(500, errorObject);
                return response;

            }
            try
            {
                
                // truy vấn sửa dữ liệu
                var sqlCommand = $"UPDATE Customer SET {columnsName} WHERE CustomerID = @CustomerIdToModify";

                var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);

                //Trả về cho client
                var response = StatusCode(200, rowEffects);
                return Ok(response);
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.errorServe,
                    devMsg = e.Message,
                    errorCode = "ms_001",

                };
                var response = StatusCode(500, errorObject);
                return response;

            }
        }
        /// <summary>
        /// xoá 1 đối tượng theo id
        /// dvlong(12/8/2021)
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        [HttpDelete("{customerId}")]
        public IActionResult DeleteById(Guid customerId)
        {
            try
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
                var sqlCommand = $"DELETE FROM Customer WHERE CustomerId = @CustomerId";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CustomerId", customerId);
                var rowEffects = dbConnection.Execute(sqlCommand, param: parameters);

                //Trả về cho client
                var response = StatusCode(200, rowEffects);
                return Ok(response);
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.errorServe,
                    devMsg = e.Message,
                    errorCode = "ms_001",

                };
                var response = StatusCode(500, errorObject);
                return response;

            }
        }
    }
}

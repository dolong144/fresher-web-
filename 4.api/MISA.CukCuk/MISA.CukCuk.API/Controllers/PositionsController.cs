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
    public class PositionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPositions()
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
            var sqlCommand = "SELECT * FROM Position";
            var positions = dbConnection.Query<Position>(sqlCommand);

            //Trả về cho client
            var response = StatusCode(200, positions);
            return Ok(response);
        }

        [HttpGet("{positionId}")]
        public IActionResult GetById(Guid positionId)
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
            var sqlCommand = $"SELECT * FROM Position WHERE PositionId = @PositionIdParam";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PositionIdParam", positionId);
            var position = dbConnection.QueryFirstOrDefault<Position>(sqlCommand, param: parameters);

            //Trả về cho client
            var response = StatusCode(200, position);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult InsertPosition(Position position)
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
            var properties = position.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                //lấy tên prop
                var propName = prop.Name;

                //lấy value của prop
                var propvalue = prop.GetValue(position);

                // lấy kiểu dữ liệu của prop
                var propType = prop.PropertyType;

                //Thêm param tương ứng với prop
                dynamicParam.Add($"@{propName}", propvalue);

                columnsName += $"{propName},";
                columnsParam += $"@{propName},";
            }
            columnsName = columnsName.Remove(columnsName.Length - 1, 1);
            columnsParam = columnsParam.Remove(columnsParam.Length - 1, 1);
            var sqlCommand = $"INSERT INTO Position ({columnsName}) VALUES({columnsParam});";

            var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);

            //Trả về cho client
            var response = StatusCode(200, rowEffects);
            return Ok(response);
        }
        [HttpPut("{positionId}")]
        public IActionResult ModifyPosition(Guid positionId, Position position)
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
            var properties = position.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                //lấy tên prop
                var propName = prop.Name;

                //lấy value của prop
                var propvalue = prop.GetValue(position);

                // lấy kiểu dữ liệu của prop
                var propType = prop.PropertyType;

                //Thêm param tương ứng với prop
                dynamicParam.Add($"@{propName}", propvalue);

                columnsName += $"{propName} = @{propName},";
                //columnsParam += $"@{propName},";
            }
            columnsName = columnsName.Remove(columnsName.Length - 1, 1);
            dynamicParam.Add($"@PositionIdToModify", positionId);
            //columnsParam = columnsParam.Remove(columnsParam.Length - 1, 1);

            // truy vấn sửa dữ liệu
            var sqlCommand = $"UPDATE Position SET {columnsName} WHERE PositionID = @PositionIdToModify";

            var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);

            //Trả về cho client
            var response = StatusCode(200, rowEffects);
            return Ok(response);
        }
        [HttpDelete("{positionId}")]
        public IActionResult DeleteById(Guid positionId)
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
            var sqlCommand = $"DELETE FROM Position WHERE PositionId = @PositionId";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@PositionId", positionId);
            var rowEffects = dbConnection.Execute(sqlCommand, param: parameters);

            //Trả về cho client
            var response = StatusCode(200, rowEffects);
            return Ok(response);
        }
    }
}

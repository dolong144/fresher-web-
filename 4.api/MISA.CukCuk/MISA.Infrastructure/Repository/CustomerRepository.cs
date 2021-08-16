using Dapper;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public int Add(Customer customer)
        {
            //Khởi tạo id mới
            customer.CustomerID = Guid.NewGuid();
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
            var sqlCommand = $"INSERT INTO Customer({columnsName}) VALUES({columnsParam})";

            var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);
            return rowEffects;
        }

        public int Delete(Guid customerId)
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
            return rowEffects;
        }

        public List<Customer> Get()
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
            return (List<Customer>)customers;
        }

        public Customer GetById(Guid customerId)
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
            return customer;
        }

        public int Update(Customer customer, Guid customerId)
        {
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

            // truy vấn sửa dữ liệu
            var sqlCommand = $"UPDATE Customer SET {columnsName} WHERE CustomerID = @CustomerIdToModify";

            var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);
            return rowEffects;
        }
    }
}

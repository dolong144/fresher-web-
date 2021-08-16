using Dapper;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Services;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _customerRepository;
        ServiceResult _serviceResult;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _serviceResult = new ServiceResult();
        }
        
        public ServiceResult Add(Customer customer)
        {
            //Xử lý nghiệp vụ
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
            //kiểm tra rỗng
            if (customer.CustomerCode == "" || customer.CustomerCode == null)
            {
                var errorObject = new
               {
                    userMsg = Properties.Resource.nullCode,
                    devMsg = Properties.Resource.nullCode,
                    errorCode = "ms_003",

               };
                _serviceResult.IsValid = false;
                _serviceResult.Data = errorObject;
                return _serviceResult;
            }
            //kiểm tra trùng
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
                _serviceResult.IsValid = false;
                _serviceResult.Data = errorObject;
                return _serviceResult;
            }
            //Kiểm tra Email
            var emailFormat = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            var isMatch = Regex.IsMatch(customer.Email, emailFormat, RegexOptions.IgnoreCase);
            if (!isMatch)
            {
               var errorObject = new
                {
                   userMsg = "Email không đúng định dạng!",
                   errorCode = "misa-005",
                };
                _serviceResult.IsValid = false;
                _serviceResult.Data = errorObject;
                return _serviceResult;
            }
            //Tương tác kêt nối database
            _serviceResult.Data = _customerRepository.Add(customer);
            _serviceResult.IsValid = true;
            return _serviceResult;
        }

        public ServiceResult Delete(Guid customerId)
        {
            //Tương tác kêt nối database
            _serviceResult.Data = _customerRepository.Delete(customerId);
            _serviceResult.IsValid = true;
            return _serviceResult;
        }

        public ServiceResult Get()
        {
            //Tương tác kêt nối database
            _serviceResult.Data = _customerRepository.Get();
            _serviceResult.IsValid = true;
            return _serviceResult;
        }

        public ServiceResult GetById(Guid customerId)
        {
            //Tương tác kêt nối database
            _serviceResult.Data = _customerRepository.GetById(customerId);
            _serviceResult.IsValid = true;
            return _serviceResult;
        }

        public ServiceResult Update(Customer customer, Guid customerId)
        {
            //Xử lý nghiệp vụ
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

            dynamicParam.Add("@CustomerIdDelete", customerId);
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
            //kiểm tra rỗng
            if (customer.CustomerCode == "" || customer.CustomerCode == null)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.nullCode,
                    devMsg = Properties.Resource.nullCode,
                    errorCode = "ms_003",

                };
                _serviceResult.IsValid = false;
                _serviceResult.Data = errorObject;
                return _serviceResult;
            }
            //kiểm tra trùng
            var sqlCommand = $"SELECT * FROM Customer WHERE CustomerCode = @CustomerCode";
            DynamicParameters parameters = new DynamicParameters();
            var checkCode = dbConnection.QueryFirstOrDefault(sqlCommand, param: dynamicParam);
            sqlCommand = $"SELECT * FROM Customer WHERE CustomerCode = @CustomerCode AND CustomerId = @CustomerIdDelete";
            var checkOldCode = dbConnection.QueryFirstOrDefault(sqlCommand, param: dynamicParam);
            if (checkCode is not null && checkOldCode is null)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.errorDoubleCode,
                    devMsg = Properties.Resource.errorDoubleCode,
                    errorCode = "ms_002",

                };
                _serviceResult.IsValid = false;
                _serviceResult.Data = errorObject;
                return _serviceResult;
            }
            //Kiểm tra Email
            var emailFormat = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            var isMatch = Regex.IsMatch(customer.Email, emailFormat, RegexOptions.IgnoreCase);
            if (!isMatch)
            {
                var errorObject = new
                {
                    userMsg = "Email không đúng định dạng!",
                    errorCode = "misa-005",
                };
                _serviceResult.IsValid = false;
                _serviceResult.Data = errorObject;
                return _serviceResult;
            }
            //Tương tác kêt nối database
            _serviceResult.Data = _customerRepository.Update(customer, customerId);
            return _serviceResult;
        }
    }
}

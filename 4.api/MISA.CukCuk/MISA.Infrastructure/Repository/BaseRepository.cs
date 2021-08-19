using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.Core.Interfaces.Repository;
using MISA.Core.MISAAtribute;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Infrastructure.Repository
{
    public class BaseRepository<MISAEntity> : IBaseRepository<MISAEntity>
    {

        public readonly string _connectionString ;
        IConfiguration _configuration;
        string _className;
        public BaseRepository(IConfiguration configuration)
        {
            _className = typeof(MISAEntity).Name;
            _connectionString = configuration.GetConnectionString("MyDatabase");
        }
        public int Add(MISAEntity entity)
        {

            // khai báo dynamic param
            var dynamicParam = new DynamicParameters();


            //Thêm dữu liệu vào database
            var columnsName = string.Empty;
            var columnsParam = string.Empty;

            //Đọc từng property của object:
            var properties = entity.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                var propertyAttributeNotMap = prop.GetCustomAttributes(typeof(MISANotMap), true);
                if(propertyAttributeNotMap.Length == 0)
                {
                    //lấy tên prop
                    var propName = prop.Name;

                    //lấy value của prop
                    var propvalue = prop.GetValue(entity);

                    //Khởi tạo id mới
                    if (propName == $"{_className}ID" && prop.PropertyType == typeof(Guid))
                    {
                        propvalue = Guid.NewGuid();
                    }

                    // lấy kiểu dữ liệu của prop
                    var propType = prop.PropertyType;

                    //Thêm param tương ứng với prop
                    dynamicParam.Add($"@{propName}", propvalue);

                    columnsName += $"{propName},";
                    columnsParam += $"@{propName},";
                }
            }
            using (IDbConnection dbConnection = new MySqlConnection(_connectionString))
            {
                columnsName = columnsName.Remove(columnsName.Length - 1, 1);
                columnsParam = columnsParam.Remove(columnsParam.Length - 1, 1);
                var sqlCommand = $"INSERT INTO {_className}({columnsName}) VALUES({columnsParam})";

                var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);
                return rowEffects;
            }
            
        }

        public int Delete(Guid entityId)
        {
            

            var sqlCommand = $"DELETE FROM {_className} WHERE {_className}Id = @EntityIdParam";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@EntityIdParam", entityId);
            //Khởi tạo đới tượng kết nối với database

            using (IDbConnection dbConnection = new MySqlConnection(_connectionString))
            {
                //Xoá dữu liệu
                
                var rowEffects = dbConnection.Execute(sqlCommand, param: parameters);

                //Trả về cho client
                return rowEffects;
            }
            
        }

        public List<MISAEntity> GetAll()
        {
            

            //Khởi tạo đới tượng kết nối với database
            
            using (IDbConnection dbConnection = new MySqlConnection(_connectionString))
            {
                //Lấy dữu liệu
                var sqlCommand = $"SELECT * FROM {_className}";
                var entities = dbConnection.Query<MISAEntity>(sqlCommand).ToList();
                return entities;
            }
            
        }

        public MISAEntity GetById(Guid entityId)
        {
            

            //Lấy dữu liệu
            var sqlCommand = $"SELECT * FROM {_className} WHERE {_className}Id = @EntityIdParam";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@EntityIdParam", entityId);

            //Khởi tạo đới tượng kết nối với database
            using (IDbConnection dbConnection = new MySqlConnection(_connectionString))
            {
                var entity = dbConnection.QueryFirstOrDefault<MISAEntity>(sqlCommand, param: parameters);
                return (MISAEntity)entity;
            }
            
        }
        public bool GetByCode(string code)
        {
            //Lấy dữu liệu
            var sqlCommand = $"SELECT * FROM {_className} WHERE {_className}Code = @EntityIdParam";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@EntityIdParam", code);

            //Khởi tạo đới tượng kết nối với database
            using (IDbConnection dbConnection = new MySqlConnection(_connectionString))
            {
                var entity = dbConnection.QueryFirstOrDefault<MISAEntity>(sqlCommand, param: parameters);
                if (entity is not null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //public string GetCode(Guid entityId)
        //{
        //    //Lấy dữu liệu
        //    var sqlCommand = $"SELECT * FROM {_className} WHERE {_className}ID = @EntityIdParam";
        //    DynamicParameters parameters = new DynamicParameters();
        //    parameters.Add("@EntityIdParam", entityId);

        //    //Khởi tạo đới tượng kết nối với database
        //    using (IDbConnection dbConnection = new MySqlConnection(_connectionString))
        //    {
        //        var entity = dbConnection.QueryFirstOrDefault<MISAEntity>(sqlCommand, param: parameters);
        //        if (entity is not null)
        //        {
        //            return entity.
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

        public int Update(MISAEntity entity, Guid entityId)
        {
            

            
            // khai báo dynamic param
            var dynamicParam = new DynamicParameters();


            //Sửa dữ liệu database
            var columnsName = string.Empty;
            var columnsParam = string.Empty;

            //Đọc từng property của object:
            var properties = entity.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                var propertyAttributeNotMap = prop.GetCustomAttributes(typeof(MISANotMap), true);
                if (propertyAttributeNotMap.Length == 0)
                {
                    //lấy tên prop
                    var propName = prop.Name;

                    //lấy value của prop
                    var propvalue = prop.GetValue(entity);

                    // lấy kiểu dữ liệu của prop
                    var propType = prop.PropertyType;

                    //Thêm param tương ứng với prop
                    dynamicParam.Add($"@{propName}", propvalue);

                    columnsName += $"{propName} = @{propName},";
                    //columnsParam += $"@{propName},";
                }
            }
            columnsName = columnsName.Remove(columnsName.Length - 1, 1);
            dynamicParam.Add($"@EntityIdToModify", entityId);

            // truy vấn sửa dữ liệu
            var sqlCommand = $"UPDATE {_className} SET {columnsName} WHERE {_className}Id = @EntityIdToModify";
            using (IDbConnection dbConnection = new MySqlConnection(_connectionString))
            {
                var rowEffects = dbConnection.Execute(sqlCommand, param: dynamicParam);
                return rowEffects;
            }
            
        }
    }
}

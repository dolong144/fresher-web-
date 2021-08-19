using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Services;
using MISA.Core.MISAAtribute;
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
    public class BaseService<MISAEntity> : IBaseService<MISAEntity>
    {
        
        IBaseRepository<MISAEntity> _baseRepository;
        ServiceResult _serviceResult;
        string _className;
        public BaseService(IBaseRepository<MISAEntity> baseRepository)
        {
            _baseRepository = baseRepository;
            _serviceResult = new ServiceResult();
            _className = typeof(MISAEntity).Name;
        }
        public ServiceResult Add(MISAEntity entity)
        {
            //validate dữ liệu, xử lí nghiệp vụ
            _serviceResult.IsValid = ValidateData(entity);
            if (_serviceResult.IsValid)
            {
                _serviceResult.IsValid = ValidateCustom(entity);
            }
            //thực hiện thêm mới
            if (_serviceResult.IsValid) {
                _serviceResult.Data = _baseRepository.Add(entity);
            }
            
            return _serviceResult;
        }
        /// <summary>
        /// Xoá đối tượng theo id
        /// </summary>
        /// <param name="entityId">Id đối tượng</param>
        /// <returns></returns>
        /// CreatedBy:dvlong(18/8/2021)
        public ServiceResult Delete(Guid entityId)
        {
            if (_serviceResult.IsValid)
            {
                _serviceResult.Data = _baseRepository.Delete(entityId);
            }

            return _serviceResult;
        }

        public ServiceResult Get()
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetById(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Update(MISAEntity entity, Guid entityId)
        {

            //validate dữ liệu, xử lí nghiệp vụ

            //thực hiện sửa
            _serviceResult.Data = _baseRepository.Update(entity,entityId);
            return _serviceResult;
        }
        /// <summary>
        /// Xử lí validate dữ liệu
        /// </summary>
        /// <param name="entity">đối tượng cần validate</param>
        /// <returns>true- hợp lệ, false-không hợp lệ</returns>
        /// createdby:dvlong(17/8/2021)
        private bool ValidateData(MISAEntity entity)
        {
            var className = typeof(MISAEntity).Name;
            var isValidate = true;
            //kiểm tra
            //Đọc từng property của object:
            var properties = entity.GetType().GetProperties();

            //Duyệt qua các property
            foreach (var prop in properties)
            {
                //lấy tên prop
                var propName = prop.Name;

                //lấy value của prop
                var propvalue = prop.GetValue(entity);

                //validate Email
                var propMISAEmail = prop.GetCustomAttributes(typeof(MISAEmail), true);
                if (propMISAEmail.Length > 0)
                {
                    var emailFormat = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                    var isMatch = Regex.IsMatch(propvalue.ToString(), emailFormat, RegexOptions.IgnoreCase);
                    if (!isMatch)
                    {

                        isValidate = false;
                        _serviceResult.Messenger = Properties.Resource.errEmail;

                    }
                }

                // check trùng mã
                var propMISACode = prop.GetCustomAttributes(typeof(MISACode), true);
                if (propMISACode.Length > 0)
                {
                    //thêm mới nhân viên
                    {
                        isValidate = !_baseRepository.GetByCode(propvalue.ToString());
                        if (!isValidate)
                        {
                            _serviceResult.Messenger = Properties.Resource.errorDoubleCode;
                        }
                    }

                    //sửa nhân viên

                    //{
                    //    var oldEntity = _baseRepository.GetById(entityId);
                    //    if(propvalue == oldEntity.)
                    //}
                }


                //validate trường bắt buộc
                var propMISARequired = prop.GetCustomAttributes(typeof(MISARequired), true);
                if (propMISARequired.Length > 0)
                {
                    if(prop.PropertyType == typeof(string) && (propvalue.ToString() == string.Empty|| propvalue.ToString() ==""))
                    {
                        isValidate = false;
                        _serviceResult.Messenger = Properties.Resource.nullString;
                    }
                }

                
            }
            return isValidate;
        }
        
        /// <summary>
        /// Xử lí validate dữ liệu cho con ghi đè
        /// </summary>
        /// <param name="entity">đối tượng cần validate</param>
        /// <returns>true- hợp lệ, false-không hợp lệ</returns>
        /// createdby:dvlong(17/8/2021)
        protected virtual bool ValidateCustom(MISAEntity entity)
        {
            return true;
        }
        
    }
}

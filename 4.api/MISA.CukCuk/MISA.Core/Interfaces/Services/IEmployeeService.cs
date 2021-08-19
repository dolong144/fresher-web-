using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces.Services
{
    public interface IEmployeeService : IBaseService<Employee>
    {
        /// <summary>
        /// thêm mới nhân viên
        /// </summary>
        /// <param name="customer">thông tin nhân viên</param>
        /// <returns>ServiceResult- kết quả xử lý qua nghiệp vụ</returns>
        /// Createby:dvlong(14/8/2021)
        //ServiceResult AddEmployee(Employee Employee);
        /// <summary>
        /// Cập nhật nhân viên
        /// </summary>
        /// <param name="customer">thông tin nhân viên</param>
        /// <returns>ServiceResult- kết quả xử lí qua nghiệp vụ</returns>
        /// Createby:dvlong(14/8/2021)
        //ServiceResult UpdateEmployee(Employee Employee, Guid EmployeeId);
    }
}

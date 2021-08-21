using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Services
{

    public class EmployeeService :BaseService<Employee>, IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        ServiceResult _serviceResult;
        public EmployeeService(IEmployeeRepository employeeRepository, IBaseRepository<Employee> baseRepository) :base(baseRepository)
        {
            _employeeRepository = employeeRepository;
            _serviceResult = new ServiceResult();
        }
        /// <summary>
        /// Hàm xử lý phân trang nhân viên
        /// </summary>
        /// <param name="employeeFilter">Dữ liệu cần lọc</param>
        /// <param name="departmentId">ID phòng ban</param>
        /// <param name="positionId">ID vị trí</param>
        /// <param name="pageIndex">Trang hiện tại</param>
        /// <param name="pageSize">Số bản ghi một trang</param>
        /// <returns>Phản hồi tương ứng</returns>
        /// CreatedBy:dvlong (19/08/2021)
        public ServiceResult Pagination(string employeeFilter, Guid? departmentId, Guid? positionId, int pageIndex, int pageSize)
        {
            _serviceResult.Data = _employeeRepository.Pagination(employeeFilter, departmentId, positionId, pageIndex, pageSize);

            return _serviceResult;
        }

        


    }
}

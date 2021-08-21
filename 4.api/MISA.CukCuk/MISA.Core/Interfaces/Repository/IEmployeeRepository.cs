using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces.Repository
{
    public interface IEmployeeRepository:IBaseRepository<Employee>
    {
        public object Pagination(string employeeFilter, Guid? departmentId, Guid? positionId, int pageIndex, int pageSize);
    }
}

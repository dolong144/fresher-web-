using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Services;
using MISA.CukCuk.API.Model;
using MySqlConnector;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : BaseEntityController<Employee>
    {
        IEmployeeRepository _employeeRepository;
        IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService, IEmployeeRepository employeeRepository):base(employeeService, employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _employeeService = employeeService;
        }

        /// <summary>
        /// Hàm xử lý phân trang cho nhân viên
        /// </summary>
        /// <param name="employeeFilter">Dữ liệu cần lọc</param>
        /// <param name="departmentId">ID phòng ban</param>
        /// <param name="positionId">ID vị trí</param>
        /// <param name="pageIndex">Trang hiện tại</param>
        /// <param name="pageSize">Số bản ghi một trang</param>
        /// <returns>Dữ liệu phân trang</returns>
        /// CreateBy:dvlong(19/08/2021)
        [HttpGet("paging")]
        public IActionResult EmployeePagination([FromQuery] string employeeFilter, [FromQuery] Guid? departmentId, [FromQuery] Guid? positionId, [FromQuery] int pageIndex, [FromQuery] int pageSize)
        {
            try
            {
                var serviceResponse = _employeeService.Pagination(employeeFilter, departmentId, positionId, pageIndex, pageSize);

                if ((int)serviceResponse.Data.GetType().GetProperty("totalRecord").GetValue(serviceResponse.Data) != 0)
                {
                    return StatusCode(200, serviceResponse.Data);
                }
                else
                {
                    return NoContent();
                }

            }
            catch (Exception)
            {
                var errorObj = new
                {
                    devMsg = "",
                    userMsg = "",
                };
                return StatusCode(500, errorObj);
            }

        }

    }
}

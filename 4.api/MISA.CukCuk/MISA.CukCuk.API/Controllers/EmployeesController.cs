using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Services;
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
    public class EmployeesController : BaseEntityController<Employee>
    {
        IEmployeeRepository _employeeRepository;
        IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService, IEmployeeRepository employeeRepository):base(employeeService, employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _employeeService = employeeService;
        }
        
    }
}

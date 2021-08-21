using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Services;
using MISA.Core.Services;
using MISA.CukCuk.API.Model;
using MySqlConnector;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MISA.CukCuk.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : BaseEntityController<Customer>
    {
        ICustomerService _customerService;
        //IBaseRepository<Customer> _customerRepository;
        ServiceResult _serviceResult;
        public CustomersController( ICustomerRepository customerRepository,ICustomerService customerService) :base(customerService, customerRepository)
        {
            _customerService = customerService;
            _serviceResult = new ServiceResult();
        }
        [HttpPost("import")]

        public async Task<IActionResult> ImportAsync(IFormFile formFile, CancellationToken cancellationToken)
        {
            if (formFile == null || formFile.Length < 1)
            {
                var errorObject = new
                {
                    devMsg = Properties.Resource.nullFile,
                    userMsg = Properties.Resource.nullFile,
                };
                return BadRequest(errorObject);
            }
            var customers = new List<Customer>();
            using (var stream = new MemoryStream())
            {
                await formFile.CopyToAsync(stream, cancellationToken);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Danh sách khách hàng"];
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 3; row <= rowCount; row++)
                    {
                        var customer = new Customer();
                        customer.CustomerCode = worksheet.Cells[row, 1].Value== null? "" : worksheet.Cells[row, 1].Value.ToString().Trim();
                        customer.FullName = worksheet.Cells[row, 2].Value == null ? "" : worksheet.Cells[row, 2].Value.ToString().Trim();
                        customer.MemberCardCode = worksheet.Cells[row, 3].Value == null ? "" : worksheet.Cells[row, 3].Value.ToString().Trim();
                        customer.MemberCardCode = worksheet.Cells[row, 4].Value == null ? "" : worksheet.Cells[row, 4].Value.ToString().Trim();
                        customer.PhoneNumber = worksheet.Cells[row, 5].Value == null ? "" : worksheet.Cells[row, 5].Value.ToString().Trim();
                        //customer.DateOfBirth = worksheet.Cells[row, 6].Value== null? "" :worksheet.Cells[row, 6].Value.ToString().Trim();
                        customer.CompanyName = worksheet.Cells[row, 7].Value == null ? "" : worksheet.Cells[row, 7].Value.ToString().Trim();
                        customer.CompanyTaxCode = worksheet.Cells[row, 8].Value == null ? "" : worksheet.Cells[row, 8].Value.ToString().Trim();
                        customer.Email = worksheet.Cells[row, 9].Value == null ? "" : worksheet.Cells[row, 9].Value.ToString().Trim();
                        customer.Address = worksheet.Cells[row, 10].Value == null ? "" : worksheet.Cells[row, 10].Value.ToString().Trim();
                        customers.Add(customer);
                    }
                }
            }

            return Ok(customers);
        }
    }
}

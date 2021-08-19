using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Services;
using MISA.Core.Services;
using MISA.CukCuk.API.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
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
        ///// <summary>
        ///// lấy toàn bộ dữ liệu
        ///// dvlong (12/8/2021)
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //public IActionResult GetCustomers()
        //{
        //    try
        //    {
        //        ServiceResult serviceResult = _customerService.Get();

        //        //Trả về cho client
        //        return serviceResult.Data is not null ? StatusCode(200, serviceResult.Data) : StatusCode(204,serviceResult.Data);
                
        //    }
        //    catch (Exception e)
        //    {
        //        var errorObject = new
        //        {
        //            userMsg = Properties.Resource.errorServe,
        //            devMsg = e.Message,
        //            errorCode = "ms_001",

        //        };
        //        return  StatusCode(500, errorObject);

        //    }
        //}
        /// <summary>
        /// Lấy thông tin theo id
        /// dvlong(12/8/2021)
        /// </summary>
        /// <param name="customerId"> id của đối tượng cần lấy</param>
        /// <returns></returns>
        //[HttpGet("{customerId}")]
        //public IActionResult GetById(Guid customerId)
        //{
        //    try
        //    {
        //        var serviceResult = _customerService.GetById(customerId);

        //        //Trả về cho client
        //        return serviceResult.Data is not null ? StatusCode(200, serviceResult.Data) : StatusCode(204,serviceResult.Data);

        //    }
        //    catch (Exception e)
        //    {
        //        var errorObject = new
        //        {
        //            userMsg = Properties.Resource.errorServe,
        //            devMsg = e.Message,
        //            errorCode = "ms_001",

        //        };
        //        return StatusCode(500, errorObject);

        //    }
        //}
        ///// <summary>
        ///// thêm mới 1 đối tượng
        ///// dvlong(12/8/2021)
        ///// </summary>
        ///// <param name="customer"></param>
        ///// <returns></returns>
        //[HttpPost]
        //public IActionResult InsertCustomer(Customer customer)
        //{
            
            
        //    try
        //    {
        //        var serviceResult = _customerService.Add(customer);

        //        //Trả về cho client
        //        if(serviceResult.IsValid) {

        //            return StatusCode(201, serviceResult.Data);
                    
        //        }
        //        else
        //        {
        //            return BadRequest(serviceResult.Data);
        //        } 
                
        //    }
        //    catch (Exception e)
        //    {
        //        var errorObject = new
        //        {
        //            userMsg = Properties.Resource.errorServe,
        //            devMsg = e.Message,
        //            errorCode = "ms_001",

        //        };
        //        var response = StatusCode(500, errorObject);
        //        return response;
        //    }
        //}
        ///// <summary>
        ///// Sửa 1 đối tượng đã có
        ///// dvlong(12/8/2021)
        ///// </summary>
        ///// <param name="customerId"></param>
        ///// <param name="customer"></param>
        ///// <returns></returns>
        //[HttpPut("{customerId}")]
        //public IActionResult Update(Guid customerId, Customer customer)
        //{
        //    try
        //    {
        //        var serviceResult = _customerService.Update(customer,customerId);

        //        //Trả về cho client
        //        if (serviceResult.IsValid)
        //        {

        //            return StatusCode(200, serviceResult.Data);

        //        }
        //        else
        //        {
        //            return BadRequest(serviceResult.Data);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        var errorObject = new
        //        {
        //            userMsg = Properties.Resource.errorServe,
        //            devMsg = e.Message,
        //            errorCode = "ms_001",

        //        };
        //        var response = StatusCode(500, errorObject);
        //        return response;

        //    }
        //}
        ///// <summary>
        ///// xoá 1 đối tượng theo id
        ///// dvlong(12/8/2021)
        ///// </summary>
        ///// <param name="customerId"></param>
        ///// <returns></returns>
        //[HttpDelete("{customerId}")]
        //public IActionResult DeleteById(Guid customerId)
        //{
        //    try
        //    {
        //        var serviceResult = _customerService.Delete(customerId);

        //        //Trả về cho client
        //        if (serviceResult.IsValid)
        //        {

        //            return StatusCode(200, serviceResult.Data);

        //        }
        //        else
        //        {
        //            return BadRequest(serviceResult.Data);
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        var errorObject = new
        //        {
        //            userMsg = Properties.Resource.errorServe,
        //            devMsg = e.Message,
        //            errorCode = "ms_001",

        //        };
        //        var response = StatusCode(500, errorObject);
        //        return response;
        //    }
        //}
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseEntityController<MISAEntity> : ControllerBase
    {
        #region Declage
        IBaseService<MISAEntity> _baseService;
        IBaseRepository<MISAEntity> _baseRepository;
        #endregion
        #region constructor
        public BaseEntityController(IBaseService<MISAEntity> baseService, IBaseRepository<MISAEntity> baseRepository)
        {
            _baseService = baseService;
            _baseRepository = baseRepository;
        }
        #endregion
        #region method
        /// <summary>
        /// lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var entities = _baseRepository.GetAll();
                return Ok(entities);
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    userMsg = Properties.Resource.errorServe,
                    devMsg = e.Message,
                    errorCode = "ms_001",

                };
                var response = StatusCode(500, errorObject);
                return response;
            }
        }
        [HttpGet("{entityId}")]
        public IActionResult GetById(Guid entityId)
        {
            try
            {
                var entity = _baseRepository.GetById(entityId);
                return Ok(entity);
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    devMsg = e.Message,
                    userMsg = Properties.Resource.errorServe,
                };
                return StatusCode(500, errorObject);
            }
        }
        [HttpPost]
        public IActionResult InsertEmployee(MISAEntity entity)
        {
            try
            {
                var res = _baseService.Add(entity);
                if (res.IsValid == true)
                {
                    return StatusCode(201, res);
                }
                else
                {
                    return BadRequest(res);
                }
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    devMsg = e.Message,
                    userMsg = Properties.Resource.errorServe,
                };
                return StatusCode(500, errorObject);
            }
        }
        [HttpDelete("{entityId}")]
        public IActionResult DeleteById(Guid entityId)
        {
            try
            {
                var rowEffect = _baseRepository.Delete(entityId);
                return Ok(rowEffect);
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    devMsg = e.Message,
                    userMsg = Properties.Resource.errorServe,
                };
                return StatusCode(500, errorObject);
            }

        }
        [HttpPut("{entityId}")]
        public IActionResult Update(MISAEntity entity, Guid entityId)
        {
            try
            {
                var rowEffect = _baseService.Update(entity, entityId);
                return Ok(rowEffect);
            }
            catch (Exception e)
            {
                var errorObject = new
                {
                    devMsg = e.Message,
                    userMsg = Properties.Resource.errorServe,
                };
                return StatusCode(500, errorObject);
            }

        }

        #endregion

    }
}

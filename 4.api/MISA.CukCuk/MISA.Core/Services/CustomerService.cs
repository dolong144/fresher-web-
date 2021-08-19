using Dapper;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Services;
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
    public class CustomerService :BaseService<Customer>, ICustomerService
    {
        ICustomerRepository _customerRepository;
        ServiceResult _serviceResult;
        public CustomerService(ICustomerRepository customerRepository):base(customerRepository)
        {
            _customerRepository = customerRepository;
            _serviceResult = new ServiceResult();
        }
        
        
    }
}

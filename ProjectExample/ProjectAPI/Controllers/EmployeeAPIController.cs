using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CoreLib.Config;
using CoreLib.DataTableToObject.Mapping;
using CoreLib.Entities;
using DataServiceLib.Interfaces.Employees;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace ProjectAPI.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {
        private readonly IEmployeeContext _employeeContext;

        public EmployeeAPIController(IEmployeeContext employeeContext)
        {
            this._employeeContext = employeeContext;
        }
       
        [HttpGet(ApiRoute.Employees)]
        public JToken GetEmployees(Employee searchOptions)
        {
            var dataSet = this._employeeContext.Get(searchOptions);

            DataTable dataTable;

            var mapper = new DataNamesMapper<Employee>();

            if (dataSet.Tables.Count > 0)
            {
                dataTable = dataSet.Tables[0];
                return JToken.FromObject(mapper.Map(dataTable));
            }
            else
            {
                return JToken.FromObject("Không bản ghi nào!");
            }
        }
        
        [HttpPost(ApiRoute.InsertEmployees)]
        public ResponseMessage Post([FromBody] Employee employee)
        {
            if (employee != null)
            {
                return this._employeeContext.Add(employee);
            }
            else
            {
                return new ResponseMessage { Code = "-1", Message = "INVALID_DATA" };
            }
        }
        
        [HttpPut(ApiRoute.UpdateEmployees)]
        public ResponseMessage Put([FromBody] Employee employee)
        {
            if (employee != null)
            {
                return this._employeeContext.Update(employee);
            }
            else
            {
                return new ResponseMessage { Code = "-1", Message = "INVALID_DATA" };
            }
        }

        
        [HttpDelete(ApiRoute.DeleteEmployees)]
        public ResponseMessage Delete(string employeeID)
        {
            if (!string.IsNullOrEmpty(employeeID))
            {
                return this._employeeContext.Delete(employeeID);
            }
            else
            {
                return new ResponseMessage { Code = "-1", Message = "INVALID_DATA" };
            }
        }
    }
}

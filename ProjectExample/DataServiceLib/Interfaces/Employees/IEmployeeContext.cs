using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Interfaces.Employees
{
    public interface IEmployeeContext : IDataContext<Employee>
    {
        DataSet Get(Employee searchOptions);

        DataSet Get(string employeeID);

        ResponseMessage Delete(string employeeID);
    }
}

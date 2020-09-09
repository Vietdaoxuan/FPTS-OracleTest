using CoreLib.DataTableToObject.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class Employee
    {
        [DataNames("EMP_ID")]
        public string EmployeeID { get; set; }

        [DataNames("FIRST_NAME")]
        public string FristName { get; set; }

        [DataNames("LAST_NAME")]
        public string LastName { get; set; }

        [DataNames("BIRTHDAY")]
        public DateTime BirthDay { get; set; }

        [DataNames("WORKDAY")]
        public DateTime WorkDay { get; set; }

        [DataNames("ADDRESS")]
        public string Address { get; set; }

        [DataNames("PHONE")]
        public string Phone { get; set; }

        [DataNames("SALARY")]
        public string Salary { get; set; }
    }
}

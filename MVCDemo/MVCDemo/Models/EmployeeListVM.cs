using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class EmployeeListVM
    {
        public EmployeeListVM()
        {

            EmployeeList = new List<EmployeeVM>();
            EmployeeList.Add(new EmployeeVM { Id = 1, Name = "Akash", Department = "Finance" });
            EmployeeList.Add(new EmployeeVM { Id = 2, Name = "Chandrasen", Department = "Admin" });
            EmployeeList.Add(new EmployeeVM { Id = 3, Name = "Rama", Department = "Finance" });
        }

        public List<EmployeeVM> EmployeeList { get; set; }
    }
}
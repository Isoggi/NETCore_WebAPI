using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.NETCoreTest.Models;

namespace WebAPI.NETCoreTest.DataAccess
{
    public interface IEmployeeInterface
    {
        List<Employee> GetEmployee();
        List<Employee> GetEmployee(List<string> filter);
        bool AddEmployee(Employee employee);
        bool EditEmployee(Employee employee);
        bool DeleteEmployee(int id);

    }
}

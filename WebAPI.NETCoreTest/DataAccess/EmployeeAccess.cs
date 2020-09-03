using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.NETCoreTest.Data;
using WebAPI.NETCoreTest.Models;

namespace WebAPI.NETCoreTest.DataAccess
{
    public class EmployeeAccess : IEmployeeInterface
    {
        private readonly DataContext _context;

        public EmployeeAccess(DataContext context)
        {
            _context = context;
        }
        public bool AddEmployee(Employee employee)
        {
            bool status = false;
            try
            {
                var lastId = _context.Employees.Max(t => t.Id);
                employee.Id = lastId + 1;
                _context.Employees.Add(employee);
                _context.SaveChanges();

                return status = true;
            }
            catch (Exception e)
            {
                return status;
                throw e;
            }
        }

        public bool DeleteEmployee(int id)
        {
            bool status = false;
            try
            {
                var employee = _context.Employees.FirstOrDefault(t => t.Id == id);
                _context.Employees.Remove(employee);
                _context.SaveChanges();

                return status = true;
            }
            catch (Exception e)
            {
                return status;
                throw e;
            }
        }

        public bool EditEmployee(Employee employee)
        {
            bool status = false;
            try
            {
                var data = _context.Employees.FirstOrDefault(t => t.Id == employee.Id);
                if (data != new Employee())
                {
                    _context.Employees.Update(data);
                    _context.SaveChanges();
                    return status = true;
                }
                else
                {
                    return status;
                }

            }
            catch (Exception e)
            {
                return status;
                throw e;
            }
        }

        public List<Employee> GetEmployee()
        {
            return _context.Employees.ToList();
        }

        public List<Employee> GetEmployee(List<string> filter)
        {
            throw new NotImplementedException();
        }
    }
}

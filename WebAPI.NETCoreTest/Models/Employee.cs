using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.NETCoreTest.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int NIK { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string Department { get; set; }
        public string Roles { get; set; }
        public string Religion { get; set; }
    }
}

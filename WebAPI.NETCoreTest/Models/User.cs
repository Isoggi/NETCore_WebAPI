using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.NETCoreTest.Models
{
    public class User : UserLogin
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

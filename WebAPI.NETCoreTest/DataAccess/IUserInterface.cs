using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.NETCoreTest.Models;

namespace WebAPI.NETCoreTest.DataAccess
{
    public interface IUserInterface
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(string id);
        bool GetUserAccess(UserLogin userLogin);
        string GetUserName(UserLogin userLogin);

    }
}

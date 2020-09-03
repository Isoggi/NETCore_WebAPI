using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.NETCoreTest.Data;
using WebAPI.NETCoreTest.Models;

namespace WebAPI.NETCoreTest.DataAccess
{
    public class UserAccess : IUserInterface
    {
        private readonly DataContext _context;

        public UserAccess(DataContext context)
        {
            _context = context;
        }

        public bool AddUser(User user)
        {
            bool status = false;
            try
            {
                var lastId = _context.Users.Max(t => t.Id);
                user.Id = lastId + 1;
                _context.Users.Add(user);
                _context.SaveChanges();

                return status = true;
            }
            catch (Exception e)
            {
                return status;
                throw e;
            }
        }

        public bool UpdateUser(User user)
        {
            bool status = false;
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();

                return status = true;
            }
            catch (Exception e)
            {
                return status;
                throw e;
            }
        }

        public bool GetUserAccess(UserLogin userLogin)
        {
            bool status = false;
            var userExist = _context.Users.FirstOrDefault(u => u.UserID == userLogin.UserID && u.Password == userLogin.Password );

            if (userExist !=  new UserLogin())
            {
                return status = true;
            }
            return status;
        }

        public string GetUserName(UserLogin userLogin)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}

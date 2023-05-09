using System;
using System.Collections.Generic;
using Fbs_webApi_v1.Models;
using Fbs_webApi_v1.interfaces;
using Fbs_webApi_v1.Db_FbsContext;


namespace Fbs_webApi_v1.Repositorys
{
    public class UserRepository : IUser
    { 

        private readonly FbsContext _usersContext;

        public UserRepository(FbsContext context)
        {
            _usersContext = context;
        }
    
        public bool AddUser(User user)
        {
            var checkuser = _usersContext.users.Where(u => u.User_Id == user.User_Id).FirstOrDefault();
            if (checkuser != null)
            {
                _usersContext.Add(user);
                _usersContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteUser(int id)
        {
            var user = _usersContext.users.Find(id);
            if (user != null) 
            {
                _usersContext.Remove(user);
                _usersContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<User> GetAllUsers()
        {
            return _usersContext.users.ToList();
        }

        public User GetUserById(int id)
        {
            var user = _usersContext.users.FirstOrDefault(u => u.User_Id == id);
            return user;
        }

        public bool UpdateUser(User user)
        {
            var oldUser = _usersContext.users.FirstOrDefault(u => u.User_Id == user.User_Id);
            if (oldUser != null) 
            {
                oldUser = user;
                _usersContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}

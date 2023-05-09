using System;
using System.Collections.Generic;
using Fbs_webApi_v1.Models;


namespace Fbs_webApi_v1.interfaces
{
    public interface IUser
    {
        List<User> GetAllUsers();
        
        User GetUserById(int id);

        bool AddUser(User user);

        bool UpdateUser(User user);

        bool DeleteUser(int id);
    }
}

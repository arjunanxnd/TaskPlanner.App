
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public static class UserRepository
    {
        private static List<User> _users = new List<User>();
        public static List<User> Users { get { return _users; } }

        public static int CurrentUID { get; set; }

        public static void AddUser(User user)
        {
            foreach (User _user in _users)
            {
                if (user.UserName == _user.UserName)
                    throw new Exception();
            }
            _users.Add(user);
        }

        public static void DeleteUser(User user)
        {
            for (int i = 0; i < _users.Count(); i++)
            {
                if (_users[i] == user)
                    _users.Remove(user);
            }
        }

        

    }
}

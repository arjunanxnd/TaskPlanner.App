
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPlanner.Data_Access;

namespace TaskPlanner.Business_Logic
{
    public class UserRepository
    {
        List<User> _users;
        public List<User> Users { get {  return _users; } }
        User _user;
        public UserRepository()
        {
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            foreach (User _user in _users)
            {
                if (user.UserName == _user.UserName)
                    throw new Exception();
            }
            _users.Add(user);
        }

        public void DeleteUser(User user)
        {
            for (int i = 0; i < _users.Count(); i++)
            {
                if (_users[i] == user)
                    _users.Remove(user);
            }
        }

        public void SaveUser(JSONDataManager dataManger)
        {
            dataManger.WriteUserInformation(Users);
        }

        public void ReadUsers(JSONDataManager dataManager)
        {
            try
            {
                _users = dataManager.LoadUsers();
            }
            catch (FileNotFoundException ex)
            {
                _users = new List<User>(); 
            }
        }
    }
}

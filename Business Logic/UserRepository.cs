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
        List<User> _users = new List<User>();
        public List<User> Users { get {  return _users; } }

        public void SaveUser(IUserDataManger dataManger)
        {
            dataManger.WriteUserInformation(Users);
        }

        public void ReadUsers(IUserDataManger dataManager)
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

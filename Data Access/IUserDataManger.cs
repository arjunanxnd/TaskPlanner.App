using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPlanner.Business_Logic;

namespace TaskPlanner.Data_Access
{
    public interface IUserDataManger
    {
        public void WriteUserInformation(List<User> users);
        public List<User> LoadUsers();

    }
}

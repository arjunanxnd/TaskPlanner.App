using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TaskPlanner.Business_Logic;

namespace TaskPlanner.Data_Access
{
    public class JSONDataManager 
    {
        string _fileName;
        public JSONDataManager(string fileName)
        {
            _fileName = fileName;
        }
        
        public void WriteUserInformation(List<User> users)
        {
            using (FileStream writer = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(writer, users);
            }
        }

        public List<User> LoadUsers()
        {
            List<User> users = new List<User>();
            using (FileStream reader = new FileStream(_fileName, FileMode.Open))
            {
                users = JsonSerializer.Deserialize<List<User>>(reader);
            }
            return users;
        }
    }
}

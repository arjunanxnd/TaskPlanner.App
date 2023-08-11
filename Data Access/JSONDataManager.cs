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
        string _jsonFileName;
        //public JSONDataManager(string jsonFileName)
        //{
        //    _jsonFileName = jsonFileName;
        //}

        public string JsonFile { get { return _jsonFileName; } set { _jsonFileName = value; } }

        //Json methods
        public void WriteUserInformation(List<User> users)
        {
            using (FileStream writer = new FileStream(_jsonFileName, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(writer, users);
            }
        }

        public List<User> LoadUsers()
        {
            List<User> users = new List<User>();
            using (FileStream reader = new FileStream(_jsonFileName, FileMode.Open))
            {
                users = JsonSerializer.Deserialize<List<User>>(reader);
            }
            return users;
        }
    }
}

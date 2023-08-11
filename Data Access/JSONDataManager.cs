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
        string _csvFilename;
        public JSONDataManager(string jsonFileName)//, string csvFilename)
        {
            _jsonFileName = jsonFileName;
        }

        public string CsvFile { get { return _csvFilename; } set { _csvFilename = value; } }

        //csv methods
        public void WriteUserID(User user)
        {
            List<string> sUsers = new List<string>();
                string sUser = Convert.ToString(user.UserId); 
                sUsers.Add(sUser);  
            File.WriteAllLines(_csvFilename, sUsers); 
        }

        public int LoadUserID()
        {
            int num = 0;
            string[] sUsers = File.ReadAllLines(_csvFilename);

            foreach (string pString in sUsers)
            {
                num= Convert.ToInt32(pString);
            }

            return num; 

        }

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

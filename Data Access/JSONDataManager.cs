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
        /*public JSONDataManager(string jsonFileName)
        {
            _jsonFileName = jsonFileName;
        }*/
        public Exception? InnerException { get; }

        public string JsonFile { get { return _jsonFileName; } set { _jsonFileName = value; } }

        //Json methods
        public void WriteUserInformation(List<User> users)
        {
            try
            {
                using (FileStream writer = new FileStream(_jsonFileName, FileMode.Create))
                {
                    JsonSerializer.Serialize(writer, users);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
                throw; // Re-throw the exception to propagate it to the caller.
            }
        }

        public List<User> LoadUsers()
        {
            try
            {
                List<User> users = new List<User>();
                using (FileStream reader = new FileStream(_jsonFileName, FileMode.Open))
                {
                    users = JsonSerializer.Deserialize<List<User>>(reader);
                }
                return users;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
                throw; // Re-throw the exception to propagate it to the caller.
            }
        }

    
    }
}

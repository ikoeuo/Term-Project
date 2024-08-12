using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Term_Project.BusinessLogic;

namespace Term_Project.DataLayer
// Author: Hira Ahmad
{
    public static class Repository
    {
        static public void SaveUserDatatoJsonFile(string filename, List<User> users)
        {
            string filePath = Path.Combine(FileSystem.Current.AppDataDirectory, filename);
            FileStream fileStream = File.OpenWrite(filePath);

            JsonSerializer.Serialize(fileStream, users);

        }
        static public List<User> ReadUserDataFromJsonFile(string filename)
        {
            string filePath = Path.Combine(FileSystem.Current.AppDataDirectory, filename);
            List<User> users = new List<User>();
            if (File.Exists(filePath))
            {
                FileStream fileStream = File.OpenRead(filePath);
                users = JsonSerializer.Deserialize<List<User>>(fileStream);
            }

            return users;
        }
    }
}

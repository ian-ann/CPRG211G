
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp20.Data
{
    public class UserManager
    {
        //private const string USER_TXT = @"C:\CPRG211 D\DemoMod4_UserValidation\Resources\Res\users.txt";
        string USER_TXT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Resources\\Res\\Users.txt");
		 
		public static List<User> users = new List<User>();

        public UserManager()
        {
            populateUsers();
        }

        private void populateUsers()
        {
            User user;

            foreach(string line in File.ReadLines(USER_TXT)) 
            {
                string[] parts = line.Split(",");
                int id = int.Parse(parts[0]);
                string email = parts[1];

                user = new User(id,email); // user object
                users.Add(user); // Add into users List


            }
        }

        public static List<User> GetUsers()  // Return type is  List<User> 
        {
            return users;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp20.Data
{
    public class User
    {
        private int id;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public User() 
        {
        }

        public User(int id, string email)
        {
            this.Id = id;
            this.Email = email;
        }
    }
}

using pharmacies.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.model
{
    public class User
    {
        private int id;
        private String userName;
        private String password;
        private Role role;

        public User()
        {
        }

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public Role Role { get => role; set => role = value; }
    }
}

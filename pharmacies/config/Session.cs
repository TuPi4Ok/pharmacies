using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.config
{
    class Session
    {
        private bool valid;
        private User currentUser;
        private Login formLogin;
        private String tableForAdmin;

        public Session(bool valid)
        {
            this.valid = valid;
        }

        public bool Valid { get => valid; set => valid = value; }
        public User CurrentUser { get => currentUser; set => currentUser = value; }
        public Login FormLogin { get => formLogin; set => formLogin = value; }
        public string TableForAdmin { get => tableForAdmin; set => tableForAdmin = value; }

        public void setSession(User user, Login login)
        {
            Valid = true;
            CurrentUser = user;
            FormLogin = login;
        }
    }
}

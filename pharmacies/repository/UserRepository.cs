using pharmacies.config;
using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.repository
{
    class UserRepository
    {

        MyApplicationContext db = new MyApplicationContext();

        public User findUserByUserName(String UserName)
        {
            try
            {
                return db.Users.Where(p => p.UserName == UserName).ToList().First();
            } catch (Exception e)
            {
                return null;
            }

        }

        public void save(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}

using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.service
{
    interface UserSerrvise
    {
        bool validate(User existingUser,User user);
        bool saveUser(User user);

        User getUser(String userName);
    }
}

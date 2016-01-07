using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm.DB
{
    public class User
    {
        public UserData udata { get; set; }
        public UserEvent uevent { get; set; }

        public User(UserData d, UserEvent e)
        {
            udata = d;
            uevent = e;
        }
    }
}

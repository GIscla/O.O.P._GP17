using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O.P._Assessment.UserLogin
{
    interface IUser
    {
        string email { get; set; }
        string password { get; set; }
        string name { get; set; }
        string surname { get; set; }

        bool verifyLogin();
    }
}

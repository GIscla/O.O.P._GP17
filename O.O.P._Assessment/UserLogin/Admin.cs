using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O.P._Assessment.UserLogin
{
    class Admin : IUser
    {
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        public bool verifyLogin()
        {

        }

        public Ttable createTimetables()
        {

        }

        public Course createCourse()
        {

        }
    }
}

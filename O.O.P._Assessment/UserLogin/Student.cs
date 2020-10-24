using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O.P._Assessment.UserLogin
{
    class Student : IUser
    {
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        public string phoneNumber;
        public bool[] attendance;
        public int[][] gradeBook; //each column is a module and each row is an evaluation

        public bool verifyLogin()
        {

        }

        public void seeGrades()
        {

        }

        public void seeAttendences()
        {

        }
    }
}

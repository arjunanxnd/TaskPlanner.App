using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public class User
    {
        private Assignment _assignment;
        private Exam _exam;
        private General _general;

        private int _userId;
        private string _password;
        private string _email;

        public User(string userName, string firstAndLast, string email, string password)
        {
            UserName = userName;
            FirstAndLastName = firstAndLast;
            E_mail = email;
            Password = password;
        }

        public string UserName { get; set; }
        public string FirstAndLastName { get; set; }
        public string Password { get { return _password; } set { _password = value; } }
        public string E_mail { get { return _email; } set { if (value.Contains("@gmail.com")) _email = value; } }

        public List<Exam> ExamList { get { return _exam.Exams; }  }
        public List<Assignment> AssignmentList { get { return _assignment.Assignments; }  }
        public List<General> GeneralList { get { return _general.Generals; }  }

        //public List<User> Users { get { return _users; } }


        public void UpdateUserpassword(User user,string pass)
        {
            user.Password = pass;
        }

        public void UpdateUserName(User user,string userName)
        {
            user.UserName = userName;
        }

        public void UpdateFirstAndLast(User user, string FAndL)
        {
            user.FirstAndLastName = FAndL;
        }


    }
}

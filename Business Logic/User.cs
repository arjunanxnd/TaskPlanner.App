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
        private List<User> _users = new List<User>();
        private string _email;
        private List<string> _subject = new List<string>();

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
        public List<string> Subjects { get { return _subject; } set { _subject = value; } }

        public List<Exam> ExamList { get { return _exam.Exams; }  }
        public List<Assignment> AssignmentList { get { return _assignment.Assignments; }  }
        public List<General> GeneralList { get { return _general.Generals; }  }

        public List<User> Users { get { return _users; } }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void UpdateUsername(string rename)
        {
            foreach (User user1 in _users)
            {
                if (user1._userId == this._userId)
                {
                    user1.UserName = rename;
                }
            }
        }

        public void UpdateUseremail(string remail)
        {
            foreach (User user1 in _users)
            {
                if (user1._userId == this._userId)
                {
                    user1._email = remail;
                }
            }
        }

        public void UpdateUserpassword(string pass)
        {
            foreach (User user1 in _users)
            {
                if (user1._userId == this._userId)
                {
                    user1._password = pass;
                }
            }
        }

        public void AddSubject(string sub)
        {
            foreach (User user1 in _users)
            {
                if (user1._userId == this._userId)
                {
                    user1._subject.Add(sub);
                }
            }
        }

        public void RemoveSubject(string sub)
        {
            foreach (User user1 in _users)
            {
                if (user1._userId == this._userId)
                {
                    user1._subject.Remove(sub);
                }
            }
        }

    }
}

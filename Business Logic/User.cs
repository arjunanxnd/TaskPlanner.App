using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public class User
    {
        private List<Assignment> _assignments;
        private List<Exam> _exams;
        public List<General> _generals;

        private int _userId;
        private string _password;
        private string _email;

        public User(string userName, string firstAndLast, string email, string password)
        {
            UserName = userName;
            FirstAndLastName = firstAndLast;
            E_mail = email;
            Password = password;
            _exams = new List<Exam>();
            _assignments = new List<Assignment>();
            _userId++;
        }

        public int UserId { get { return _userId; } }
        public string UserName { get; set; }
        public string FirstAndLastName { get; set; }
        public string Password { get { return _password; } set { _password = value; } }
        public string E_mail { get { return _email; } set { if (value.Contains("@gmail.com")) _email = value; } }

        public List<Exam> ExamList { get { return _exams; }  }
        public List<Assignment> AssignmentList { get { return _assignments; }  }
        public List<General> GeneralList { get { return _generals; } }

        
        //user
        public void UpdateUserpassword(User user,string pass)
        {
            user.Password = pass;
        }
        public void UpdateUserName(User user,string userName)
        {
            user.UserName = userName;
        }

        //assignment
        public void UpdateFirstAndLast(User user, string FAndL)
        {
            user.FirstAndLastName = FAndL;
        }

        public void AddAssignment(Assignment assignment) //Add assignment obj in the list
        {
            _assignments.Add(assignment);
        }
        public void DeleteAssessment(Assignment assignment) 
        {
            DateTime date = assignment.DueDate;
            string var = assignment.Description;
            string sub = assignment.Subject;
            for (int i = 0; i < _assignments.Count(); i++)
            {
                if (assignment.DueDate == date && assignment.Subject == sub && assignment.Description == var)
                {
                    _assignments.Remove(assignment);
                    break;
                }
            }
        }

        //exam
        public void AddExam(Exam exam) //Add exam obj in the list
        {
            _exams.Add(exam);
        }
        public void DeleteExam(Exam exam)
        {
            DateTime date = exam.DueDate;
            string var = exam.Description;
            string sub = exam.Subject;
            for (int i=0;i<_exams.Count();i++)
            {
                if (exam.DueDate == date && exam.Subject == sub && exam.Description == var)
                {
                    _exams.Remove(exam);
                    break;
                }
            }
        }

        //general
        public void AddGeneral(General general) //Add general obj in the list
        {
            _generals.Add(general);
        }
        public void DeleteGeneral(General general)
        {
            DateTime date = general.WorkDate;
            string var = general.Description;
            string title = general.Title;
            for (int i = 0; i < _exams.Count(); i++)
            {
                if (general.WorkDate == date && general.Title == title && general.Description == var)
                {
                    _generals.Remove(general);
                    break;
                }
            }
        }


    }
}

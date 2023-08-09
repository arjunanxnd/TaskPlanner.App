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
            _exams = new List<Exam>();
            _assignments = new List<Assignment>();
        }

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

        public void AddAssignment(Assignment assignment)
        {
            _assignments.Add(assignment);
        }
        public void DeleteAssessment(Assignment assignment) 
        {
            
            foreach (Assignment var in _assignments)
            {
                if (assignment.DueDate == var.DueDate && assignment.Description.ToLower() == var.Description.ToLower())
                    _assignments.Remove(assignment);
            }
        }

        //exam
        public void AddExam(Exam exam)
        {
            _exams.Add(exam);
        }

        public void DeleteExam(Exam exam)
        {
            foreach (Exam dt in _exams)
            {
                if (exam.DueDate == dt.DueDate && exam.Etype == dt.Etype)
                    _exams.Remove(exam);
            }
        }

        //general
        public void AddGeneral(General general)
        {
            _generals.Add(general);
        }

        public void DeleteGeneral(General general)
        {
            foreach (General current in _generals)
            {
                if (current.WorkDate == general.WorkDate && general.Title.ToLower() == current.Title.ToLower())
                {
                    _generals.Remove(general);
                }
            }
        }
    }
}

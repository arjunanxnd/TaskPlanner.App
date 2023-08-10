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

        private string _password;
        private string _email;

        public User(string userName, string firstAndLast, string email, string password, List<Assignment> assignments, List<Exam> exams, List<General> generals)
        {
            UserName = userName;
            FirstAndLastName = firstAndLast;
            E_mail = email;
            Password = password;

            exams = new List<Exam>();
            assignments = new List<Assignment>();
            generals = new List<General>();
            _assignments = assignments;
            _exams = exams;
            _generals = generals;
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstAndLastName { get; set; }
        public string Password { get { return _password; } set { _password = value; } }
        public string E_mail { get { return _email; } set { if (value.Contains("@gmail.com")) _email = value; else throw new Exception("Please enter a Gmail Email id"); } }

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
            for (int i = 0; i < _assignments.Count(); i++)
            {
                if (_assignments[i] == assignment)
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
            for (int i=0;i<_exams.Count();i++)
            {
                if (_exams[i] == exam)
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
            for (int i = 0; i < _exams.Count(); i++)
            {
                if (_generals[i] == general)
                {
                    _generals.Remove(general);
                    break;
                }
            }
        }

        public override string ToString()
        {
            return $"{UserName} || {UserId}";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskPlanner.Business_Logic
{
    public class User
    {
        private ObservableCollection<Assignment>? _assignments;
        private ObservableCollection<Exam>? _exams;
        public ObservableCollection<General>? _generals;


        public int userId;
        private string _password;
        private string _email;

        public User(string userName, string firstAndLastName, string e_mail, string password, ObservableCollection<Assignment> assignments, ObservableCollection<Exam> exams, ObservableCollection<General> generals)
        {
            UserID++;
            userId = UserID;
            UserName = userName;
            FirstAndLastName = firstAndLastName;
            E_mail = e_mail;
            Password = password;

            exams = new ObservableCollection<Exam>();
            assignments = new ObservableCollection<Assignment>();
            generals = new ObservableCollection<General>();
            _assignments = assignments;
            _exams = exams;
            _generals = generals;
        }

        public static int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstAndLastName { get; set; }
        public string Password { get { return _password; } set { _password = value; } }
        public string E_mail { get { return _email; } set { if (value.Contains("@gmail.com")) _email = value; else throw new Exception("Please enter a Gmail Email id"); } }

        public ObservableCollection<Exam> ExamList { get { return _exams; }  }
        public ObservableCollection<Assignment> AssignmentList { get { return _assignments; }  }
        public ObservableCollection<General> GeneralList { get { return _generals; } }

        
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
        public void DeleteAssignment(Assignment assignment)
        {
            foreach (Assignment existingAssignment in _assignments)
            {
                if (existingAssignment == assignment)
                {
                    _assignments.Remove(existingAssignment);
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
            foreach (Exam currentExam in _exams)
            {
                if (currentExam == exam)
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
            foreach (var existingGeneral in _generals.ToList())
            {
                if (existingGeneral == general)
                {
                    _generals.Remove(existingGeneral);
                    break;
                }
            }
        }

        public override string ToString()
        {
            return $"{UserName}";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public enum ExamType
    {
        FinalExam,
        Quiz,
        MidTerms
    }

    public class Exam : Assessment
    {
        private List<Exam> _exam;
        public List<Exam> Exams { get { return _exam; } }
        public ExamType Etype { get; set; }

        public Exam()
        {
            _exam = new List<Exam>();
        }

        public void AddExam(Exam exam)
        {
            _exam.Add(exam);
        }

        public void DeleteExam(Exam exam)
        {
            foreach (Exam dt in _exam)
            {
                if (exam.DueDate == dt.DueDate && exam.Etype == dt.Etype)
                    _exam.Remove(exam);
            }
        }

    }
}

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
        public ExamType Etype { get; set; }

        public Exam(string subject, string description, DateTime dueDate, ExamType exam)
        {
            Subject = subject;
            Description = description;
            DueDate = dueDate;
            Etype = exam;
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

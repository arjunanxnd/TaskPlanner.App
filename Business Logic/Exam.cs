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

        public Exam()
        {

        }

        public Exam(string subject, string description, DateOnly dueDate, ExamType exam)
        {
            Subject = subject;
            Description = description;
            DueDate = dueDate;
            Etype = exam;
        }

        public override string ToString()
        {
            return $"{Subject} - {Description} - {DueDate} - {Etype}";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    class Exam : Assessment
    {
        private List<Exam> _exam = new List<Exam>();
        public List<Exam> Exams { get { return _exam; } }

        public override void AddAssesment(Exam exam)
        {
            _exam.Add(exam);
        }

        public override void DeleteAssesment(Exam exam)
        {
            foreach (Exam dt in _exam)
            {
                if (exam.DueDate == dt.DueDate)
                    _exam.Remove(exam);
            }
        }
    }
}

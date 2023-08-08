using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    class Assignment : Assessment
    {
        private List<Assignment> _assignments = new List<Assignment>();
        public List<Assignment> Assignments { get { return _assignments; } }

        public void AddAssesment(Assignment assignment)
        {
            _assignments.Add(assignment);
        }

        public void DeleteAssessment(Assignment assignment) //have to make more stuff
        {
            foreach(Assignment var in _assignments)
            {
                if (assignment.DueDate == var.DueDate)
                    _assignments.Remove(assignment);
            }
        }



    }
}

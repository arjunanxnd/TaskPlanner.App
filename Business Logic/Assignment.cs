using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public class Assignment : Assessment
    {
        private List<Assignment> _assignments;
        public List<Assignment> Assignments { get { return _assignments; } }

        public Assignment()
        {
            _assignments = new List<Assignment>();
        }

        public void AddAssesment(Assignment assignment)
        {
            _assignments.Add(assignment);
        }

        public void DeleteAssessment(Assignment assignment) //have to make more stuff
        {
            foreach (Assignment var in _assignments)
            {
                if (assignment.DueDate == var.DueDate && assignment.Description.ToLower() == var.Description.ToLower())
                    _assignments.Remove(assignment);
            }
        }

    }

}

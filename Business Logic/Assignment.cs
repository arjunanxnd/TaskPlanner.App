using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public class Assignment : Assessment
    {
        public Assignment(string subject, string description, DateTime dueDate)
        {
            Subject = subject;
            Description = description;
            DueDate = dueDate;
        }

        public void AddAssesment(Assignment assignment)
        {
            
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

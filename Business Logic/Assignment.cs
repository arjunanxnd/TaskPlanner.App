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

        public override string ToString()
        {
            return $"{Subject} - {Description} - {DueDate}";
        }

    }

}

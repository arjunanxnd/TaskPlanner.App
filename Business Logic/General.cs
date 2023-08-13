using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TaskPlanner.Business_Logic
{
    public class General
    {
        public DateOnly WorkDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public General(string title, string description,DateOnly workDate)
        {
            WorkDate = workDate;
            Title = title;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Title} - {Description} - {WorkDate}";
        }
    }
}

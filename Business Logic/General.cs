using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public class General
    {
        public DateTime WorkDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public General(string title, string description,DateTime workDate)
        {
            WorkDate = workDate;
            Title = title;
            Description = description;
        }

    }
}

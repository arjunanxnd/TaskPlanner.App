using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public abstract class Assessment
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateOnly DueDate { get; set; }

    }
}

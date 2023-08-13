using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    [JsonDerivedType(typeof(Assessment), typeDiscriminator: "Assessment")]
    public abstract class Assessment
    {
        public Assessment()
        {
            Subject = "";
            Description = "";
            DueDate = DateTime.Now;
        }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

    }
}

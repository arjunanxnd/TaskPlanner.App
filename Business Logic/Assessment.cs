﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public abstract class Assessment
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        enum TypeOfAssessment
        {
            Exam,
            Assignment
        }

        public Assessment(string subject, string description)
        {
            Subject = subject;
            Description = description;
        }

        public abstract void AddAssesment();

        public abstract void UpdateAssesment();

        public abstract void DeleteAssesment();
    }
}

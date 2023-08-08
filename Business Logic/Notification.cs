using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public class Notification
    {
        private Assignment _assignment;
        private Exam _exam;
        private General _general;
        public List<Notification> _notifications = new List<Notification>();
        public List<Assignment> AssignmentList { get { return _assignment.Assignments; } }
        public List<Exam> ExamList { get { return _exam.; } }
        public List<General> GeneralList { get { return _general.AccessGeneral; } }

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public class General
    {
        private List<General> _generalList = new List<General>();
        public DateTime WorkDate  { get; set; }
        public string GeneralDesc { get; set; }
        public string Note { get; set; }
        public List<General> AccessGeneral { get { return _generalList; }}

        public override void AddGeneral(General general)
        {
            _generalList.Add(general);
        }

        public override void DeleteGeneral(General general)
        {
            foreach(General _general in _generalList)
            {
                if (general == _general)
                {
                    _generalList.Remove(general);
                }
            }
        }
    }
}

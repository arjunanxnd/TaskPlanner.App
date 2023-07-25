using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Business_Logic
{
    public class General
    {
        List<General> _general = new List<General>();
        public DateTime WorkDate  { get; set; }
        public string GeneralDesc { get; set; }
        public string Note { get; set; }
        public List<General> SelectedGeneral { get { return _general; }}
    }
}

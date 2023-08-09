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

        public List<General> _generals;
        public List<General> Generals { get { return _generals; } }

        public General()
        {
            _generals = new List<General>();
        }

        public void AddGeneral(General general)
        {
            _generals.Add(general);
        }

        public void DeleteGeneral(General general)
        {
            foreach (General current in _generals)
            {
                if (current.WorkDate == general.WorkDate && general.Title.ToLower() == current.Title.ToLower())
                {
                    _generals.Remove(general);
                }
            }
        }

    }
}

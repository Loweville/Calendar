using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Appointment : IAppointment
    {
        private DateTime start;
        private int len;
        private string desc;
        private bool recurs;
        private int occ;

        public Appointment(DateTime s, int l, string d, bool r, int o)
        {
            start = s;
            len = l;
            desc = d;
            recurs = r;
            occ = o;
        }

        public DateTime Start
        {
            get
            {
                return start;
            }
        }

        public int Length
        {
            get
            {
                return len;
            }
        }

        public string DisplayableDescription
        {
            get
            {
                return desc;
            }
        }

        public int Occurances
        {
            get
            {
                return occ;
            }
        }

        public bool OccursOnDate(DateTime date)
        {
            if (start.Date == date.Date)
            {
                return true;
            }

            return false;
        }

        public bool IsRecurring
        {
            get
            {
                return recurs;
            }
        }
    }
}

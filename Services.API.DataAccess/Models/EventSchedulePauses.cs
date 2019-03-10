using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class EventSchedulePauses
    {
        public int PkEventSchedulePause { get; set; }
        public int FkEventSchedule { get; set; }
        public DateTime DateForm { get; set; }
        public DateTime DateTo { get; set; }
        public string Reason { get; set; }

        public virtual EventSchedules FkEventScheduleNavigation { get; set; }
    }
}

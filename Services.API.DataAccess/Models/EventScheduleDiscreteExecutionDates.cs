using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class EventScheduleDiscreteExecutionDates
    {
        public int PkEventScheduleDiscreteExecutionDate { get; set; }
        public int? FkEventSchedule { get; set; }
        public DateTime ExecutionDate { get; set; }

        public virtual EventSchedules FkEventScheduleNavigation { get; set; }
    }
}

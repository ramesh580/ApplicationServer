using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class EventSchedules
    {
        public EventSchedules()
        {
            EventScheduleDiscreteExecutionDates = new HashSet<EventScheduleDiscreteExecutionDates>();
            EventSchedulePauses = new HashSet<EventSchedulePauses>();
        }

        public int PkEventSchedule { get; set; }
        public int? FkStoredJobDefinition { get; set; }
        public int? FkObservationPlan { get; set; }
        public bool? Enabled { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string DaysOfMonth { get; set; }
        public string MonthOfYear { get; set; }
        public string DaysOfWeek { get; set; }
        public string HoursOfDay { get; set; }
        public string MinutesOfHour { get; set; }
        public string TimeZoneId { get; set; }

        public virtual ObservationPlans FkObservationPlanNavigation { get; set; }
        public virtual StoredJobDefinitions FkStoredJobDefinitionNavigation { get; set; }
        public virtual ICollection<EventScheduleDiscreteExecutionDates> EventScheduleDiscreteExecutionDates { get; set; }
        public virtual ICollection<EventSchedulePauses> EventSchedulePauses { get; set; }
    }
}

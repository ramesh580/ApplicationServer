using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ObservationPlans
    {
        public ObservationPlans()
        {
            EventSchedules = new HashSet<EventSchedules>();
            ObservationPlanViolations = new HashSet<ObservationPlanViolations>();
        }

        public int PkObservationPlan { get; set; }
        public int MinimumObservations { get; set; }
        public int Timespan { get; set; }
        public bool ApprovedOnly { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? MaximumObservations { get; set; }
        public byte TimespanType { get; set; }
        public int? FkContainerContextSetting { get; set; }
        public byte ExecutionStatus { get; set; }
        public DateTimeOffset? LatestExecution { get; set; }
        public byte ErroneousHandling { get; set; }
        public int Month { get; set; }
        public byte TimeIntervalsDefinitionMode { get; set; }
        public byte SimpleTimeIntervalsType { get; set; }
        public DateTimeOffset? SimpleTimeIntervalsStart { get; set; }
        public DateTimeOffset? SimpleTimeIntervalsEnd { get; set; }
        public bool ReminderActive { get; set; }
        public int MinimumResponseTime { get; set; }
        public int MaximumResponseTime { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public byte MessageSeverity { get; set; }
        public string ReminderAddressees { get; set; }

        public virtual ContainerContextSettings FkContainerContextSettingNavigation { get; set; }
        public virtual ICollection<EventSchedules> EventSchedules { get; set; }
        public virtual ICollection<ObservationPlanViolations> ObservationPlanViolations { get; set; }
    }
}

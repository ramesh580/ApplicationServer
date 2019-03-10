using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ObservationAlarms
    {
        public ObservationAlarms()
        {
            ObservationAlarmAcknowledgingObligations = new HashSet<ObservationAlarmAcknowledgingObligations>();
        }

        public int PkObservationAlarm { get; set; }
        public long FkObservation { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public byte Severity { get; set; }
        public string Title { get; set; }
        public int? FkUserAcknowledgedBy { get; set; }
        public DateTimeOffset? AcknowledgedOn { get; set; }
        public string AcknowledgingNotes { get; set; }
        public DateTimeOffset? AcknowledgementDeadline { get; set; }
        public bool AcknowledgementRequested { get; set; }
        public string Action { get; set; }
        public int? FkObservationSpyingDefinition { get; set; }
        public string AlarmReason { get; set; }
        public bool ImportedAlarm { get; set; }
        public string OriginallyAcknowledgedBy { get; set; }

        public virtual Observations FkObservationNavigation { get; set; }
        public virtual ObservationSpyingDefinitions FkObservationSpyingDefinitionNavigation { get; set; }
        public virtual Users FkUserAcknowledgedByNavigation { get; set; }
        public virtual ICollection<ObservationAlarmAcknowledgingObligations> ObservationAlarmAcknowledgingObligations { get; set; }
    }
}

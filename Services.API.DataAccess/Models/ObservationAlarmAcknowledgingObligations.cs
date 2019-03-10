using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ObservationAlarmAcknowledgingObligations
    {
        public int PkObservationAlarmAcknowledgingObligation { get; set; }
        public int FkObservationAlarm { get; set; }
        public int FkUser { get; set; }

        public virtual ObservationAlarms FkObservationAlarmNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
    }
}

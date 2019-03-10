using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ObservationPlanViolations
    {
        public int PkObservationPlanViolation { get; set; }
        public int FkObservationPlan { get; set; }
        public int? FkFeature { get; set; }
        public DateTimeOffset ViolationIntervalFrom { get; set; }
        public DateTimeOffset ViolationIntervalTo { get; set; }
        public int ViolationDelta { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual ObservationPlans FkObservationPlanNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AppliedObservationTags
    {
        public int PkAppliedObservationTags { get; set; }
        public int FkObservationTag { get; set; }
        public long FkObservation { get; set; }

        public virtual Observations FkObservationNavigation { get; set; }
        public virtual ObservationTags FkObservationTagNavigation { get; set; }
    }
}

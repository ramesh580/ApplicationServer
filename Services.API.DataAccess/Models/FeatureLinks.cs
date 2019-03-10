using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureLinks
    {
        public int PkFeatureLink { get; set; }
        public long? FkObservation { get; set; }
        public int? FkFeature { get; set; }
        public int FkFeatureDestination { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }
        public Guid? PropertyStructureInstanceGuid { get; set; }

        public virtual Features FkFeatureDestinationNavigation { get; set; }
        public virtual Features FkFeatureNavigation { get; set; }
        public virtual Observations FkObservationNavigation { get; set; }
    }
}

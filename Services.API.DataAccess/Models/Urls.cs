using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Urls
    {
        public int PkUrl { get; set; }
        public string Url { get; set; }
        public long? FkObservation { get; set; }
        public int? FkFeature { get; set; }
        public string Name { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }
        public Guid? PropertyStructureInstanceGuid { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual Observations FkObservationNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AxisOffsetSpatialData
    {
        public long PkAxisOffsetSpatialDatum { get; set; }
        public int? FkFeature { get; set; }
        public long? FkObservation { get; set; }
        public double? Offset1 { get; set; }
        public double? Offset2 { get; set; }
        public float? LcsOffsetTransversal { get; set; }
        public float? LcsOffsetLongitudinal { get; set; }
        public float? LcsOffsetHeight { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual Observations FkObservationNavigation { get; set; }
    }
}

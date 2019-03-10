using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class GeometricSpatialData
    {
        public long PkGeometricSpatialDatum { get; set; }
        public int? FkFeature { get; set; }
        public long? FkObservation { get; set; }
        public double? Elevation { get; set; }
        public float? Height { get; set; }
        public float? Depth { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual Observations FkObservationNavigation { get; set; }
    }
}

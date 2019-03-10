using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AllowedSensorTypes
    {
        public int PkAllowedSensorType { get; set; }
        public int FkFeatureType { get; set; }
        public Guid SensorTypeGuid { get; set; }

        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
    }
}

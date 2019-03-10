using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class UsedClassificationTypes
    {
        public int PkUsedClassificationType { get; set; }
        public int? FkFeatureType { get; set; }
        public int? FkSensorType { get; set; }
        public Guid ClassificationTypeGuid { get; set; }

        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
        public virtual SensorTypes FkSensorTypeNavigation { get; set; }
    }
}

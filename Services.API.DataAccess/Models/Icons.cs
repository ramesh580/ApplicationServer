using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Icons
    {
        public Icons()
        {
            Iconfiles = new HashSet<Iconfiles>();
        }

        public int PkIcon { get; set; }
        public int? FkFeatureType { get; set; }
        public int? FkSensorType { get; set; }

        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
        public virtual SensorTypes FkSensorTypeNavigation { get; set; }
        public virtual ICollection<Iconfiles> Iconfiles { get; set; }
    }
}

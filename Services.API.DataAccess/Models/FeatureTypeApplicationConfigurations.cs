using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureTypeApplicationConfigurations
    {
        public int PkFeatureTypeApplicationConfiguration { get; set; }
        public int FkFeatureType { get; set; }
        public byte ApplicationType { get; set; }
        public string SerializedConfiguration { get; set; }

        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
    }
}

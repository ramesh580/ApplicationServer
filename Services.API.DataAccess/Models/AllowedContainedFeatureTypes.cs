using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AllowedContainedFeatureTypes
    {
        public int PkAllowedContainedFeatureType { get; set; }
        public int FkFeatureTypeContainer { get; set; }
        public Guid ContainedFeatureTypeGuid { get; set; }
        public int MaximumAllowedNumber { get; set; }

        public virtual FeatureTypes FkFeatureTypeContainerNavigation { get; set; }
    }
}

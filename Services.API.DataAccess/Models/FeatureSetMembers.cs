using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureSetMembers
    {
        public int FkFeatureSet { get; set; }
        public int FkFeature { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual FeatureSets FkFeatureSetNavigation { get; set; }
    }
}

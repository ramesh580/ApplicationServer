using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AppliedFeatureTags
    {
        public int PkAppliedFeatureTag { get; set; }
        public int FkFeatureTag { get; set; }
        public int FkFeature { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual FeatureTags FkFeatureTagNavigation { get; set; }
    }
}

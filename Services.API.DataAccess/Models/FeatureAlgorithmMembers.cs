using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureAlgorithmMembers
    {
        public int PkFeatureCalculationMember { get; set; }
        public int FkFeatureCalculatedFeature { get; set; }
        public int FkFeatureSourceFeature { get; set; }

        public virtual Features FkFeatureCalculatedFeatureNavigation { get; set; }
        public virtual Features FkFeatureSourceFeatureNavigation { get; set; }
    }
}

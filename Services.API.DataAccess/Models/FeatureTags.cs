using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureTags
    {
        public FeatureTags()
        {
            AppliedFeatureTags = new HashSet<AppliedFeatureTags>();
        }

        public int PkFeatureTag { get; set; }
        public int FkFeatureType { get; set; }
        public int FkDataDomain { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SequenceNumber { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
        public virtual ICollection<AppliedFeatureTags> AppliedFeatureTags { get; set; }
    }
}

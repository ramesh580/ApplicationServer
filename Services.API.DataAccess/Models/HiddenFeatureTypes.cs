using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class HiddenFeatureTypes
    {
        public int FkDataDomain { get; set; }
        public int FkFeatureType { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
    }
}

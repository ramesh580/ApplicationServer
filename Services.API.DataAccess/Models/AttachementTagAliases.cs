using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AttachementTagAliases
    {
        public int PkAttachementTagAlias { get; set; }
        public int FkDataDomain { get; set; }
        public int FkFeatureType { get; set; }
        public byte TagNo { get; set; }
        public string AliasName { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
    }
}

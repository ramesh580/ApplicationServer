using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureCreationTemplates
    {
        public int PkFeatureCreationTemplate { get; set; }
        public int FkDataDomain { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreationTemplate { get; set; }
        public string Path { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
    }
}

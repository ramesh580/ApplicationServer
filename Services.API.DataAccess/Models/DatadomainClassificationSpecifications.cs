using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class DatadomainClassificationSpecifications
    {
        public int PkDatadomainClassificationSpecification { get; set; }
        public int FkClassificationType { get; set; }
        public int FkDataDomain { get; set; }
        public int FkClassificationUsed { get; set; }

        public virtual ClassificationTypes FkClassificationTypeNavigation { get; set; }
        public virtual Classifications FkClassificationUsedNavigation { get; set; }
        public virtual DataDomains FkDataDomainNavigation { get; set; }
    }
}

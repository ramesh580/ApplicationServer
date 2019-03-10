using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Classifications
    {
        public Classifications()
        {
            ClassificationElements = new HashSet<ClassificationElements>();
            DatadomainClassificationSpecifications = new HashSet<DatadomainClassificationSpecifications>();
            PropertyStructureConfigurationContexts = new HashSet<PropertyStructureConfigurationContexts>();
        }

        public int PkClassification { get; set; }
        public int FkClassificationType { get; set; }
        public int FkDataDomain { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual ClassificationTypes FkClassificationTypeNavigation { get; set; }
        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual ICollection<ClassificationElements> ClassificationElements { get; set; }
        public virtual ICollection<DatadomainClassificationSpecifications> DatadomainClassificationSpecifications { get; set; }
        public virtual ICollection<PropertyStructureConfigurationContexts> PropertyStructureConfigurationContexts { get; set; }
    }
}

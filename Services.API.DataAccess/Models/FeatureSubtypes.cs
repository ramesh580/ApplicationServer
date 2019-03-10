using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureSubtypes
    {
        public FeatureSubtypes()
        {
            ContainerContextSettings = new HashSet<ContainerContextSettings>();
            Features = new HashSet<Features>();
            PropertyStructureConfigurationContexts = new HashSet<PropertyStructureConfigurationContexts>();
        }

        public int PkFeatureSubtype { get; set; }
        public int FkFeatureType { get; set; }
        public int FkDataDomain { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Icon { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
        public virtual ICollection<ContainerContextSettings> ContainerContextSettings { get; set; }
        public virtual ICollection<Features> Features { get; set; }
        public virtual ICollection<PropertyStructureConfigurationContexts> PropertyStructureConfigurationContexts { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class PropertyStructureConfigurations
    {
        public PropertyStructureConfigurations()
        {
            PropertyCollectionConfigurations = new HashSet<PropertyCollectionConfigurations>();
            PropertyConfigurations = new HashSet<PropertyConfigurations>();
        }

        public int PkPropertyStructureConfiguration { get; set; }
        public int FkPropertyStructure { get; set; }
        public string StylingSpecification { get; set; }
        public string LabelingSpecification { get; set; }

        public virtual PropertyStructures FkPropertyStructureNavigation { get; set; }
        public virtual PropertyStructureConfigurationContexts PropertyStructureConfigurationContexts { get; set; }
        public virtual ICollection<PropertyCollectionConfigurations> PropertyCollectionConfigurations { get; set; }
        public virtual ICollection<PropertyConfigurations> PropertyConfigurations { get; set; }
    }
}

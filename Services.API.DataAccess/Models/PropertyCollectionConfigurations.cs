using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class PropertyCollectionConfigurations
    {
        public int PkPropertyCollectionConfiguration { get; set; }
        public int FkPropertyCollection { get; set; }
        public int FkPropertyStructureConfiguration { get; set; }
        public int? MinCount { get; set; }
        public int? MaxCount { get; set; }
        public bool Hidden { get; set; }
        public int? SequenceNumber { get; set; }
        public bool UseValidationSettings { get; set; }
        public bool UseDisplaySettings { get; set; }
        public string StylingSpecification { get; set; }
        public string LabelingSpecification { get; set; }

        public virtual PropertyCollections FkPropertyCollectionNavigation { get; set; }
        public virtual PropertyStructureConfigurations FkPropertyStructureConfigurationNavigation { get; set; }
    }
}

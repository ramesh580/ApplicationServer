using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureConfigurations
    {
        public FeatureConfigurations()
        {
            PropertyStructureConfigurationContexts = new HashSet<PropertyStructureConfigurationContexts>();
        }

        public int PkFeatureConfiguration { get; set; }
        public string ValidationRule { get; set; }
        public string VisualAppearance { get; set; }
        public int? FkPropertyStructure { get; set; }
        public string LinkedPresentationTemplates { get; set; }
        public bool? UseObservationSamplingTimestamp { get; set; }
        public bool? UseObservationResultTimestamp { get; set; }
        public bool? UseObservationErroneousFlag { get; set; }
        public bool? UseObservationSensor { get; set; }
        public string ObservationSamplingTimestampDisplayName { get; set; }
        public string ObservationResultTimestampDisplayName { get; set; }
        public bool UseObservationNumber { get; set; }
        public bool ObservationOrderingDescending { get; set; }

        public virtual PropertyStructures FkPropertyStructureNavigation { get; set; }
        public virtual ICollection<PropertyStructureConfigurationContexts> PropertyStructureConfigurationContexts { get; set; }
    }
}

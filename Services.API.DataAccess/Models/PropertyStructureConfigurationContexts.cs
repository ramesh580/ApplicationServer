using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class PropertyStructureConfigurationContexts
    {
        public int PkPropertyStructureConfigurationContext { get; set; }
        public int? FkPropertyStructureConfiguration { get; set; }
        public int? FkDataDomain { get; set; }
        public int? FkFeatureType { get; set; }
        public int? FkSensorType { get; set; }
        public int? FkFeatureSubtype { get; set; }
        public int? FkClassificationType { get; set; }
        public int? FkFeature { get; set; }
        public int? FkSensor { get; set; }
        public int? FkClassification { get; set; }
        public int? FkFeatureConfiguration { get; set; }

        public virtual Classifications FkClassificationNavigation { get; set; }
        public virtual ClassificationTypes FkClassificationTypeNavigation { get; set; }
        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual FeatureConfigurations FkFeatureConfigurationNavigation { get; set; }
        public virtual Features FkFeatureNavigation { get; set; }
        public virtual FeatureSubtypes FkFeatureSubtypeNavigation { get; set; }
        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
        public virtual PropertyStructureConfigurations FkPropertyStructureConfigurationNavigation { get; set; }
        public virtual Sensors FkSensorNavigation { get; set; }
        public virtual SensorTypes FkSensorTypeNavigation { get; set; }
    }
}

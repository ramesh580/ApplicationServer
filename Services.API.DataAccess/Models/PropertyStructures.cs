using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class PropertyStructures
    {
        public PropertyStructures()
        {
            FeatureConfigurations = new HashSet<FeatureConfigurations>();
            Properties = new HashSet<Properties>();
            PropertyCollections = new HashSet<PropertyCollections>();
            PropertyStructureConfigurations = new HashSet<PropertyStructureConfigurations>();
            PropertyStructureInstances = new HashSet<PropertyStructureInstances>();
        }

        public int PkPropertyStructure { get; set; }
        public Guid PropertyStructureGuid { get; set; }
        public string IntName { get; set; }
        public int? FkFeatureTypeMetadata { get; set; }
        public int? FkFeatureTypeObservation { get; set; }
        public int? FkSensorTypeMetadata { get; set; }
        public int? FkSensorTypeObservationConfiguration { get; set; }
        public int? FkSensorTypeChronologicalConfiguration { get; set; }
        public int? FkPropertyCollection { get; set; }
        public DateTimeOffset? Version { get; set; }
        public int? FkClassificationType { get; set; }
        public bool UsesCalculatedProperties { get; set; }

        public virtual ClassificationTypes FkClassificationTypeNavigation { get; set; }
        public virtual FeatureTypes FkFeatureTypeMetadataNavigation { get; set; }
        public virtual FeatureTypes FkFeatureTypeObservationNavigation { get; set; }
        public virtual PropertyCollections FkPropertyCollectionNavigation { get; set; }
        public virtual SensorTypes FkSensorTypeChronologicalConfigurationNavigation { get; set; }
        public virtual SensorTypes FkSensorTypeMetadataNavigation { get; set; }
        public virtual SensorTypes FkSensorTypeObservationConfigurationNavigation { get; set; }
        public virtual ICollection<FeatureConfigurations> FeatureConfigurations { get; set; }
        public virtual ICollection<Properties> Properties { get; set; }
        public virtual ICollection<PropertyCollections> PropertyCollections { get; set; }
        public virtual ICollection<PropertyStructureConfigurations> PropertyStructureConfigurations { get; set; }
        public virtual ICollection<PropertyStructureInstances> PropertyStructureInstances { get; set; }
    }
}

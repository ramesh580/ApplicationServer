using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureTypes
    {
        public FeatureTypes()
        {
            AllowedContainedFeatureTypes = new HashSet<AllowedContainedFeatureTypes>();
            AllowedSensorTypes = new HashSet<AllowedSensorTypes>();
            AssociatedClassificationTypes = new HashSet<AssociatedClassificationTypes>();
            AttachementTagAliases = new HashSet<AttachementTagAliases>();
            ContainerContextSettings = new HashSet<ContainerContextSettings>();
            FeatureSubtypes = new HashSet<FeatureSubtypes>();
            FeatureTags = new HashSet<FeatureTags>();
            FeatureTypeApplicationConfigurations = new HashSet<FeatureTypeApplicationConfigurations>();
            Features = new HashSet<Features>();
            HiddenFeatureTypes = new HashSet<HiddenFeatureTypes>();
            Icons = new HashSet<Icons>();
            ObservationTags = new HashSet<ObservationTags>();
            Privileges = new HashSet<Privileges>();
            PropertyStructureConfigurationContexts = new HashSet<PropertyStructureConfigurationContexts>();
            UsedClassificationTypes = new HashSet<UsedClassificationTypes>();
        }

        public int PkFeatureType { get; set; }
        public Guid FeatureTypeGuid { get; set; }
        public Guid NameGuid { get; set; }
        public Guid? DescriptionGuid { get; set; }
        public byte FeatureTypeVersion { get; set; }
        public byte FeatureTypeClass { get; set; }
        public byte SpatialDataSupport { get; set; }
        public int AllowedSpatialSystems { get; set; }
        public int AllowedGeometryTypes { get; set; }
        public Guid? PathGuid { get; set; }
        public bool? AllowObservations { get; set; }
        public bool SingleObservation { get; set; }
        public string CustomPath { get; set; }
        public string CustomDescription { get; set; }
        public string CustomName { get; set; }

        public virtual PropertyStructures PropertyStructuresFkFeatureTypeMetadataNavigation { get; set; }
        public virtual PropertyStructures PropertyStructuresFkFeatureTypeObservationNavigation { get; set; }
        public virtual ICollection<AllowedContainedFeatureTypes> AllowedContainedFeatureTypes { get; set; }
        public virtual ICollection<AllowedSensorTypes> AllowedSensorTypes { get; set; }
        public virtual ICollection<AssociatedClassificationTypes> AssociatedClassificationTypes { get; set; }
        public virtual ICollection<AttachementTagAliases> AttachementTagAliases { get; set; }
        public virtual ICollection<ContainerContextSettings> ContainerContextSettings { get; set; }
        public virtual ICollection<FeatureSubtypes> FeatureSubtypes { get; set; }
        public virtual ICollection<FeatureTags> FeatureTags { get; set; }
        public virtual ICollection<FeatureTypeApplicationConfigurations> FeatureTypeApplicationConfigurations { get; set; }
        public virtual ICollection<Features> Features { get; set; }
        public virtual ICollection<HiddenFeatureTypes> HiddenFeatureTypes { get; set; }
        public virtual ICollection<Icons> Icons { get; set; }
        public virtual ICollection<ObservationTags> ObservationTags { get; set; }
        public virtual ICollection<Privileges> Privileges { get; set; }
        public virtual ICollection<PropertyStructureConfigurationContexts> PropertyStructureConfigurationContexts { get; set; }
        public virtual ICollection<UsedClassificationTypes> UsedClassificationTypes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class PropertyStructureInstances
    {
        public PropertyStructureInstances()
        {
            BinaryPropertyValues = new HashSet<BinaryPropertyValues>();
            BooleanPropertyValues = new HashSet<BooleanPropertyValues>();
            ClassificationPropertyValues = new HashSet<ClassificationPropertyValues>();
            FeatureLinkPropertyValues = new HashSet<FeatureLinkPropertyValues>();
            GeometryPropertyValues = new HashSet<GeometryPropertyValues>();
            MultiselectClassificationPropertyValues = new HashSet<MultiselectClassificationPropertyValues>();
            NumericPropertyValues = new HashSet<NumericPropertyValues>();
            PropertyCollectionMemberInstances = new HashSet<PropertyCollectionMemberInstances>();
            QuantityPropertyValues = new HashSet<QuantityPropertyValues>();
            ReferencedImagePropertyValues = new HashSet<ReferencedImagePropertyValues>();
            StringPropertyValues = new HashSet<StringPropertyValues>();
        }

        public long PkPropertyStructureInstance { get; set; }
        public int FkPropertyStructure { get; set; }
        public int? FkPropertyCollectionMemberInstance { get; set; }
        public long? FkObservation { get; set; }
        public long? FkObservationFlat { get; set; }
        public int? FkFeature { get; set; }
        public int? FkFeatureFlat { get; set; }
        public int? FkSensor { get; set; }
        public long? FkObservationSensorConfiguration { get; set; }
        public long? FkObservationSensorConfigurationFlat { get; set; }
        public int? FkChronologicalSensorConfiguration { get; set; }
        public DateTimeOffset? LastUpdatePropertyStructureInstance { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public int CollectionPosition { get; set; }
        public DateTimeOffset? LastUpdate { get; set; }
        public int? FkClassificationElement { get; set; }
        public int? FkSensorFlat { get; set; }
        public int? FkChronologicalSensorConfigurationFlat { get; set; }
        public Guid PropertyStructureInstanceGuid { get; set; }

        public virtual ChronologicalSensorConfigurations FkChronologicalSensorConfigurationFlatNavigation { get; set; }
        public virtual ChronologicalSensorConfigurations FkChronologicalSensorConfigurationNavigation { get; set; }
        public virtual ClassificationElements FkClassificationElementNavigation { get; set; }
        public virtual Features FkFeatureFlatNavigation { get; set; }
        public virtual Features FkFeatureNavigation { get; set; }
        public virtual Observations FkObservationFlatNavigation { get; set; }
        public virtual Observations FkObservationNavigation { get; set; }
        public virtual Observations FkObservationSensorConfigurationFlatNavigation { get; set; }
        public virtual Observations FkObservationSensorConfigurationNavigation { get; set; }
        public virtual PropertyCollectionMemberInstances FkPropertyCollectionMemberInstanceNavigation { get; set; }
        public virtual PropertyStructures FkPropertyStructureNavigation { get; set; }
        public virtual Sensors FkSensorFlatNavigation { get; set; }
        public virtual Sensors FkSensorNavigation { get; set; }
        public virtual ICollection<BinaryPropertyValues> BinaryPropertyValues { get; set; }
        public virtual ICollection<BooleanPropertyValues> BooleanPropertyValues { get; set; }
        public virtual ICollection<ClassificationPropertyValues> ClassificationPropertyValues { get; set; }
        public virtual ICollection<FeatureLinkPropertyValues> FeatureLinkPropertyValues { get; set; }
        public virtual ICollection<GeometryPropertyValues> GeometryPropertyValues { get; set; }
        public virtual ICollection<MultiselectClassificationPropertyValues> MultiselectClassificationPropertyValues { get; set; }
        public virtual ICollection<NumericPropertyValues> NumericPropertyValues { get; set; }
        public virtual ICollection<PropertyCollectionMemberInstances> PropertyCollectionMemberInstances { get; set; }
        public virtual ICollection<QuantityPropertyValues> QuantityPropertyValues { get; set; }
        public virtual ICollection<ReferencedImagePropertyValues> ReferencedImagePropertyValues { get; set; }
        public virtual ICollection<StringPropertyValues> StringPropertyValues { get; set; }
    }
}

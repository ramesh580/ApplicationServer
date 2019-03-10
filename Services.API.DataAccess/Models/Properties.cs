using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Properties
    {
        public Properties()
        {
            BinaryPropertyValues = new HashSet<BinaryPropertyValues>();
            BooleanPropertyValues = new HashSet<BooleanPropertyValues>();
            ClassificationPropertyValues = new HashSet<ClassificationPropertyValues>();
            FeatureLinkPropertyValues = new HashSet<FeatureLinkPropertyValues>();
            GeometryPropertyValues = new HashSet<GeometryPropertyValues>();
            MultiselectClassificationPropertyValues = new HashSet<MultiselectClassificationPropertyValues>();
            NumericPropertyValues = new HashSet<NumericPropertyValues>();
            PropertyConfigurations = new HashSet<PropertyConfigurations>();
            QuantityPropertyValues = new HashSet<QuantityPropertyValues>();
            ReferencedImagePropertyValues = new HashSet<ReferencedImagePropertyValues>();
            StringPropertyValues = new HashSet<StringPropertyValues>();
        }

        public int PkProperty { get; set; }
        public Guid PropertyGuid { get; set; }
        public int FkPropertyStructure { get; set; }
        public byte PropertyType { get; set; }
        public int? FkQuantityType { get; set; }
        public int? FkClassificationType { get; set; }
        public Guid NameGuid { get; set; }
        public Guid? DescriptionGuid { get; set; }
        public int SequenceNumber { get; set; }
        public string AllowedFeatureTypes { get; set; }
        public string IdentifyingName { get; set; }
        public int? AllowedGeometryTypes { get; set; }
        public string CalculationFormula { get; set; }
        public byte PropertySubType { get; set; }

        public virtual ClassificationTypes FkClassificationTypeNavigation { get; set; }
        public virtual PropertyStructures FkPropertyStructureNavigation { get; set; }
        public virtual QuantityTypes FkQuantityTypeNavigation { get; set; }
        public virtual ICollection<BinaryPropertyValues> BinaryPropertyValues { get; set; }
        public virtual ICollection<BooleanPropertyValues> BooleanPropertyValues { get; set; }
        public virtual ICollection<ClassificationPropertyValues> ClassificationPropertyValues { get; set; }
        public virtual ICollection<FeatureLinkPropertyValues> FeatureLinkPropertyValues { get; set; }
        public virtual ICollection<GeometryPropertyValues> GeometryPropertyValues { get; set; }
        public virtual ICollection<MultiselectClassificationPropertyValues> MultiselectClassificationPropertyValues { get; set; }
        public virtual ICollection<NumericPropertyValues> NumericPropertyValues { get; set; }
        public virtual ICollection<PropertyConfigurations> PropertyConfigurations { get; set; }
        public virtual ICollection<QuantityPropertyValues> QuantityPropertyValues { get; set; }
        public virtual ICollection<ReferencedImagePropertyValues> ReferencedImagePropertyValues { get; set; }
        public virtual ICollection<StringPropertyValues> StringPropertyValues { get; set; }
    }
}

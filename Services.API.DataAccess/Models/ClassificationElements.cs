using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ClassificationElements
    {
        public ClassificationElements()
        {
            ClassificationPropertyValues = new HashSet<ClassificationPropertyValues>();
            HiddenClassificationElements = new HashSet<HiddenClassificationElements>();
            MultiselectClassificationPropertyValueSelections = new HashSet<MultiselectClassificationPropertyValueSelections>();
            PropertyStructureInstances = new HashSet<PropertyStructureInstances>();
        }

        public int PkClassificationElement { get; set; }
        public int FkClassification { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short SequenceNumber { get; set; }
        public string VisualAppearance { get; set; }
        public double? LowerNumericClassBoundary { get; set; }
        public double? UpperNumericClassBoundary { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual Classifications FkClassificationNavigation { get; set; }
        public virtual ICollection<ClassificationPropertyValues> ClassificationPropertyValues { get; set; }
        public virtual ICollection<HiddenClassificationElements> HiddenClassificationElements { get; set; }
        public virtual ICollection<MultiselectClassificationPropertyValueSelections> MultiselectClassificationPropertyValueSelections { get; set; }
        public virtual ICollection<PropertyStructureInstances> PropertyStructureInstances { get; set; }
    }
}

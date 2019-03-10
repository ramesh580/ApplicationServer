using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ClassificationTypes
    {
        public ClassificationTypes()
        {
            Classifications = new HashSet<Classifications>();
            DatadomainClassificationSpecifications = new HashSet<DatadomainClassificationSpecifications>();
            Properties = new HashSet<Properties>();
            PropertyStructureConfigurationContexts = new HashSet<PropertyStructureConfigurationContexts>();
            PropertyStructures = new HashSet<PropertyStructures>();
        }

        public int PkClassificationType { get; set; }
        public Guid ClassificationTypeGuid { get; set; }
        public Guid NameGuid { get; set; }
        public Guid? DescriptionGuid { get; set; }
        public byte ClassificationTypeVersion { get; set; }
        public Guid? PathGuid { get; set; }

        public virtual ICollection<Classifications> Classifications { get; set; }
        public virtual ICollection<DatadomainClassificationSpecifications> DatadomainClassificationSpecifications { get; set; }
        public virtual ICollection<Properties> Properties { get; set; }
        public virtual ICollection<PropertyStructureConfigurationContexts> PropertyStructureConfigurationContexts { get; set; }
        public virtual ICollection<PropertyStructures> PropertyStructures { get; set; }
    }
}

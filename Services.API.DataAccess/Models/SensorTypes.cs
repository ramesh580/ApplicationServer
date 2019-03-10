using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class SensorTypes
    {
        public SensorTypes()
        {
            Icons = new HashSet<Icons>();
            PropertyStructureConfigurationContexts = new HashSet<PropertyStructureConfigurationContexts>();
            PropertyStructuresFkSensorTypeChronologicalConfigurationNavigation = new HashSet<PropertyStructures>();
            Sensors = new HashSet<Sensors>();
            UsedClassificationTypes = new HashSet<UsedClassificationTypes>();
        }

        public int PkSensorType { get; set; }
        public Guid SensorTypeGuid { get; set; }
        public Guid NameGuid { get; set; }
        public Guid? DescriptionGuid { get; set; }
        public byte SensorTypeVersion { get; set; }
        public Guid? PathGuid { get; set; }
        public string CustomPath { get; set; }
        public string CustomDescription { get; set; }
        public string CustomName { get; set; }

        public virtual PropertyStructures PropertyStructuresFkSensorTypeMetadataNavigation { get; set; }
        public virtual PropertyStructures PropertyStructuresFkSensorTypeObservationConfigurationNavigation { get; set; }
        public virtual ICollection<Icons> Icons { get; set; }
        public virtual ICollection<PropertyStructureConfigurationContexts> PropertyStructureConfigurationContexts { get; set; }
        public virtual ICollection<PropertyStructures> PropertyStructuresFkSensorTypeChronologicalConfigurationNavigation { get; set; }
        public virtual ICollection<Sensors> Sensors { get; set; }
        public virtual ICollection<UsedClassificationTypes> UsedClassificationTypes { get; set; }
    }
}

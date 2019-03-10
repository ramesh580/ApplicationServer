using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ChronologicalSensorConfigurations
    {
        public ChronologicalSensorConfigurations()
        {
            PropertyStructureInstancesFkChronologicalSensorConfigurationFlatNavigation = new HashSet<PropertyStructureInstances>();
            PropertyStructureInstancesFkChronologicalSensorConfigurationNavigation = new HashSet<PropertyStructureInstances>();
        }

        public int PkChronologicalSensorConfiguration { get; set; }
        public int FkSensor { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTo { get; set; }

        public virtual Sensors FkSensorNavigation { get; set; }
        public virtual ICollection<PropertyStructureInstances> PropertyStructureInstancesFkChronologicalSensorConfigurationFlatNavigation { get; set; }
        public virtual ICollection<PropertyStructureInstances> PropertyStructureInstancesFkChronologicalSensorConfigurationNavigation { get; set; }
    }
}

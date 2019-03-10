using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Sensors
    {
        public Sensors()
        {
            ChronologicalSensorConfigurations = new HashSet<ChronologicalSensorConfigurations>();
            Features = new HashSet<Features>();
            Observations = new HashSet<Observations>();
            PropertyStructureConfigurationContexts = new HashSet<PropertyStructureConfigurationContexts>();
            PropertyStructureInstancesFkSensorFlatNavigation = new HashSet<PropertyStructureInstances>();
        }

        public int PkSensor { get; set; }
        public int FkSensorType { get; set; }
        public int FkDataDomain { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual SensorTypes FkSensorTypeNavigation { get; set; }
        public virtual PropertyStructureInstances PropertyStructureInstancesFkSensorNavigation { get; set; }
        public virtual ICollection<ChronologicalSensorConfigurations> ChronologicalSensorConfigurations { get; set; }
        public virtual ICollection<Features> Features { get; set; }
        public virtual ICollection<Observations> Observations { get; set; }
        public virtual ICollection<PropertyStructureConfigurationContexts> PropertyStructureConfigurationContexts { get; set; }
        public virtual ICollection<PropertyStructureInstances> PropertyStructureInstancesFkSensorFlatNavigation { get; set; }
    }
}

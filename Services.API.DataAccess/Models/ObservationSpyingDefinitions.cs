using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ObservationSpyingDefinitions
    {
        public ObservationSpyingDefinitions()
        {
            ObservationAlarms = new HashSet<ObservationAlarms>();
        }

        public int PkObservationSpyingDefinition { get; set; }
        public bool OnCreation { get; set; }
        public bool OnModification { get; set; }
        public string Name { get; set; }
        public int FkUserOwner { get; set; }
        public string Description { get; set; }
        public string ObservationSpyingDefinition { get; set; }
        public int? FkContainerContextSetting { get; set; }

        public virtual ContainerContextSettings FkContainerContextSettingNavigation { get; set; }
        public virtual Users FkUserOwnerNavigation { get; set; }
        public virtual ICollection<ObservationAlarms> ObservationAlarms { get; set; }
    }
}

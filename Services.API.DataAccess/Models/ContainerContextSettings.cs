using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ContainerContextSettings
    {
        public ContainerContextSettings()
        {
            ApprovalTemplateAssignements = new HashSet<ApprovalTemplateAssignements>();
            ObservationPlans = new HashSet<ObservationPlans>();
            ObservationSpyingDefinitions = new HashSet<ObservationSpyingDefinitions>();
        }

        public int PkContainerContextSetting { get; set; }
        public int FkFeature { get; set; }
        public int? FkFeatureType { get; set; }
        public int? FkFeatureSubtype { get; set; }
        public byte ContextSettingType { get; set; }
        public byte Applicability { get; set; }
        public bool? Active { get; set; }
        public string NameFilter { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual FeatureSubtypes FkFeatureSubtypeNavigation { get; set; }
        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
        public virtual ICollection<ApprovalTemplateAssignements> ApprovalTemplateAssignements { get; set; }
        public virtual ICollection<ObservationPlans> ObservationPlans { get; set; }
        public virtual ICollection<ObservationSpyingDefinitions> ObservationSpyingDefinitions { get; set; }
    }
}

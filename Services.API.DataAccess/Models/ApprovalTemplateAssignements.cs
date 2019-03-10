using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ApprovalTemplateAssignements
    {
        public int PkApprovalTemplateAssignement { get; set; }
        public bool AutoStartWorkflowForFeature { get; set; }
        public bool AutoStartWorkflowForObservation { get; set; }
        public int? FkApprovalTemplateFeature { get; set; }
        public int? FkApprovalTemplateObservation { get; set; }
        public int? FkContainerContextSetting { get; set; }

        public virtual ApprovalTemplates FkApprovalTemplateFeatureNavigation { get; set; }
        public virtual ApprovalTemplates FkApprovalTemplateObservationNavigation { get; set; }
        public virtual ContainerContextSettings FkContainerContextSettingNavigation { get; set; }
    }
}

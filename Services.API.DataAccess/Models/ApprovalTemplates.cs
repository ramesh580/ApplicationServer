using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ApprovalTemplates
    {
        public ApprovalTemplates()
        {
            ApprovalTemplateAssignementsFkApprovalTemplateFeatureNavigation = new HashSet<ApprovalTemplateAssignements>();
            ApprovalTemplateAssignementsFkApprovalTemplateObservationNavigation = new HashSet<ApprovalTemplateAssignements>();
            ApprovalTemplateStages = new HashSet<ApprovalTemplateStages>();
        }

        public int PkApprovalTemplate { get; set; }
        public int FkDataDomain { get; set; }
        public byte ApprovalProcessSecurity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual ICollection<ApprovalTemplateAssignements> ApprovalTemplateAssignementsFkApprovalTemplateFeatureNavigation { get; set; }
        public virtual ICollection<ApprovalTemplateAssignements> ApprovalTemplateAssignementsFkApprovalTemplateObservationNavigation { get; set; }
        public virtual ICollection<ApprovalTemplateStages> ApprovalTemplateStages { get; set; }
    }
}

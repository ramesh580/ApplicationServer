using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ApprovalTemplateStages
    {
        public ApprovalTemplateStages()
        {
            ApprovalTemplateObligations = new HashSet<ApprovalTemplateObligations>();
        }

        public int PkApprovalTemplateStage { get; set; }
        public int FkApprovalTemplate { get; set; }
        public byte MinimumApprovals { get; set; }
        public int? ApprovalTimespan { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool AutoApprovalOnOverdue { get; set; }
        public byte StageSequceneNo { get; set; }

        public virtual ApprovalTemplates FkApprovalTemplateNavigation { get; set; }
        public virtual ICollection<ApprovalTemplateObligations> ApprovalTemplateObligations { get; set; }
    }
}

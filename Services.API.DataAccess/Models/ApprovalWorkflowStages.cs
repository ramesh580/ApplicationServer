using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ApprovalWorkflowStages
    {
        public ApprovalWorkflowStages()
        {
            ApprovalWorkflowObligations = new HashSet<ApprovalWorkflowObligations>();
        }

        public int PkApprovalWorkflowStage { get; set; }
        public int FkApprovalWorkflow { get; set; }
        public byte MinimumApprovals { get; set; }
        public bool AutoApprovalOnOverdue { get; set; }
        public DateTimeOffset? Start { get; set; }
        public int? ApprovalTimespan { get; set; }
        public byte StageSequenceNo { get; set; }
        public bool StageClosed { get; set; }

        public virtual ApprovalWorkflows FkApprovalWorkflowNavigation { get; set; }
        public virtual ICollection<ApprovalWorkflowObligations> ApprovalWorkflowObligations { get; set; }
    }
}

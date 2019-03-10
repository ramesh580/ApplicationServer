using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ApprovalWorkflowObligations
    {
        public int PkApprovalWorkflowObligation { get; set; }
        public int FkApprovalWorkflowStage { get; set; }
        public int FkUser { get; set; }
        public byte ApprovalStatus { get; set; }
        public DateTimeOffset LastApprovalStatusChange { get; set; }
        public string ApprovalNotes { get; set; }
        public DateTimeOffset? ApprovalTimestamp { get; set; }
        public DateTimeOffset? LastUpdate { get; set; }

        public virtual ApprovalWorkflowStages FkApprovalWorkflowStageNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ApprovalWorkflows
    {
        public ApprovalWorkflows()
        {
            ApprovalWorkflowAssignements = new HashSet<ApprovalWorkflowAssignements>();
            ApprovalWorkflowStages = new HashSet<ApprovalWorkflowStages>();
        }

        public int PkApprovalWorkflow { get; set; }
        public int? FkFeature { get; set; }
        public DateTimeOffset Start { get; set; }
        public byte ApprovalStatus { get; set; }
        public DateTimeOffset LastApprovalStatusChange { get; set; }
        public byte ApprovalProcessSecurity { get; set; }
        public bool Obsolete { get; set; }
        public int? FkUserSetObsolete { get; set; }
        public bool ApprovedButErroneous { get; set; }
        public int? FkUserSetErroneous { get; set; }
        public string ApprovedButErroneousComment { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ObsoleteComment { get; set; }
        public DateTimeOffset? LastUpdate { get; set; }
        public int? FkFeatureObservation { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual Features FkFeatureObservationNavigation { get; set; }
        public virtual Users FkUserSetErroneousNavigation { get; set; }
        public virtual Users FkUserSetObsoleteNavigation { get; set; }
        public virtual ICollection<ApprovalWorkflowAssignements> ApprovalWorkflowAssignements { get; set; }
        public virtual ICollection<ApprovalWorkflowStages> ApprovalWorkflowStages { get; set; }
    }
}

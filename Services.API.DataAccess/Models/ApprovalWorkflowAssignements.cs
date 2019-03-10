using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ApprovalWorkflowAssignements
    {
        public int PkApprovalWorkflowAssignement { get; set; }
        public int FkApprovalWorkflow { get; set; }
        public long FkObservation { get; set; }

        public virtual ApprovalWorkflows FkApprovalWorkflowNavigation { get; set; }
        public virtual Observations FkObservationNavigation { get; set; }
    }
}

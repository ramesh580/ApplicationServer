using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ApprovalTemplateObligations
    {
        public int PkApprovalObligation { get; set; }
        public int FkApprovalStage { get; set; }
        public int? FkUser { get; set; }
        public int? FkUserGroup { get; set; }

        public virtual ApprovalTemplateStages FkApprovalStageNavigation { get; set; }
        public virtual UserGroups FkUserGroupNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
    }
}

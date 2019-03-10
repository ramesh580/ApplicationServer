using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class WorkspaceAssociations
    {
        public int PkWorkspaceAssociation { get; set; }
        public int FkWorkspace { get; set; }
        public int? FkUser { get; set; }
        public int? FkUserGroup { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual UserGroups FkUserGroupNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
        public virtual Workspaces FkWorkspaceNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class UserGroups
    {
        public UserGroups()
        {
            ApprovalTemplateObligations = new HashSet<ApprovalTemplateObligations>();
            InverseFkUserGroupNavigation = new HashSet<UserGroups>();
            Privileges = new HashSet<Privileges>();
            UserGroupMemberships = new HashSet<UserGroupMemberships>();
            WorkspaceAssociations = new HashSet<WorkspaceAssociations>();
        }

        public int PkUserGroup { get; set; }
        public int? FkUserGroup { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual UserGroups FkUserGroupNavigation { get; set; }
        public virtual ICollection<ApprovalTemplateObligations> ApprovalTemplateObligations { get; set; }
        public virtual ICollection<UserGroups> InverseFkUserGroupNavigation { get; set; }
        public virtual ICollection<Privileges> Privileges { get; set; }
        public virtual ICollection<UserGroupMemberships> UserGroupMemberships { get; set; }
        public virtual ICollection<WorkspaceAssociations> WorkspaceAssociations { get; set; }
    }
}

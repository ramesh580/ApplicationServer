using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class UserGroupMemberships
    {
        public int PkUserGroupMembership { get; set; }
        public int FkUserGroup { get; set; }
        public int FkUser { get; set; }

        public virtual UserGroups FkUserGroupNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
        public virtual StaticTimespans StaticTimespans { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class StaticTimespans
    {
        public int PkStaticTimespan { get; set; }
        public DateTimeOffset? LowerBoundary { get; set; }
        public bool? LowerBoundaryInclusive { get; set; }
        public DateTimeOffset? UpperBoundary { get; set; }
        public bool? UpperBoundaryInclusive { get; set; }
        public int? FkUserGroupMembership { get; set; }
        public int? FkUser { get; set; }

        public virtual UserGroupMemberships FkUserGroupMembershipNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
    }
}

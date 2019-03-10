using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureGroupMembers
    {
        public int PkFeatureFroupMember { get; set; }
        public int FkFeatureGroup { get; set; }
        public int FkFeatureMember { get; set; }
        public int SequenceNumber { get; set; }

        public virtual Features FkFeatureGroupNavigation { get; set; }
        public virtual Features FkFeatureMemberNavigation { get; set; }
    }
}

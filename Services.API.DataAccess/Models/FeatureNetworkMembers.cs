using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureNetworkMembers
    {
        public FeatureNetworkMembers()
        {
            InverseFkFeatureNetworkMemberConnectedFromNavigation = new HashSet<FeatureNetworkMembers>();
            InverseFkFeatureNetworkMemberConnectedToNavigation = new HashSet<FeatureNetworkMembers>();
        }

        public int PkFeatureNetworkMember { get; set; }
        public int FkFeatureNetwork { get; set; }
        public int FkFeatureMember { get; set; }
        public int? FkFeatureNetworkMemberConnectedFrom { get; set; }
        public int? FkFeatureNetworkMemberConnectedTo { get; set; }

        public virtual Features FkFeatureMemberNavigation { get; set; }
        public virtual FeatureNetworkMembers FkFeatureNetworkMemberConnectedFromNavigation { get; set; }
        public virtual FeatureNetworkMembers FkFeatureNetworkMemberConnectedToNavigation { get; set; }
        public virtual Features FkFeatureNetworkNavigation { get; set; }
        public virtual ICollection<FeatureNetworkMembers> InverseFkFeatureNetworkMemberConnectedFromNavigation { get; set; }
        public virtual ICollection<FeatureNetworkMembers> InverseFkFeatureNetworkMemberConnectedToNavigation { get; set; }
    }
}

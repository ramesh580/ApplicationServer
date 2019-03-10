using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureSets
    {
        public FeatureSets()
        {
            FeatureSetMembers = new HashSet<FeatureSetMembers>();
        }

        public int PkFeatureSet { get; set; }
        public int FkUser { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Users FkUserNavigation { get; set; }
        public virtual ICollection<FeatureSetMembers> FeatureSetMembers { get; set; }
    }
}

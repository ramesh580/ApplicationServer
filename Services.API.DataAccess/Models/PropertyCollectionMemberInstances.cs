using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class PropertyCollectionMemberInstances
    {
        public PropertyCollectionMemberInstances()
        {
            PropertyStructureInstances = new HashSet<PropertyStructureInstances>();
        }

        public int PkPropertyCollectionMemberInstance { get; set; }
        public long? FkPropertyStructureInstance { get; set; }
        public int FkPropertyCollection { get; set; }

        public virtual PropertyCollections FkPropertyCollectionNavigation { get; set; }
        public virtual PropertyStructureInstances FkPropertyStructureInstanceNavigation { get; set; }
        public virtual ICollection<PropertyStructureInstances> PropertyStructureInstances { get; set; }
    }
}

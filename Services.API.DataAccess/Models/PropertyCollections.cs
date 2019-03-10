using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class PropertyCollections
    {
        public PropertyCollections()
        {
            PropertyCollectionConfigurations = new HashSet<PropertyCollectionConfigurations>();
            PropertyCollectionMemberInstances = new HashSet<PropertyCollectionMemberInstances>();
        }

        public int PkPropertyCollection { get; set; }
        public Guid PropertyCollectionGuid { get; set; }
        public int FkPropertyStructure { get; set; }
        public Guid NameGuid { get; set; }
        public Guid? DescriptionGuid { get; set; }
        public int SequenceNumber { get; set; }
        public string IdentifyingName { get; set; }

        public virtual PropertyStructures FkPropertyStructureNavigation { get; set; }
        public virtual PropertyStructures PropertyStructures { get; set; }
        public virtual ICollection<PropertyCollectionConfigurations> PropertyCollectionConfigurations { get; set; }
        public virtual ICollection<PropertyCollectionMemberInstances> PropertyCollectionMemberInstances { get; set; }
    }
}

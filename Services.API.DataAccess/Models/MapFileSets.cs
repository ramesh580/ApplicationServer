using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MapFileSets
    {
        public MapFileSets()
        {
            FileReferences = new HashSet<FileReferences>();
        }

        public int PkMapFileSet { get; set; }
        public int FkDataDomain { get; set; }
        public int FkCoordinateSystem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte MapFileSetType { get; set; }

        public virtual CoordinateSystems FkCoordinateSystemNavigation { get; set; }
        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual ICollection<FileReferences> FileReferences { get; set; }
    }
}

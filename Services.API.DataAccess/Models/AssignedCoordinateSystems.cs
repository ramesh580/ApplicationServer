using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AssignedCoordinateSystems
    {
        public int PkAssignedCoordinateSystems { get; set; }
        public int FkCoordinateSystem { get; set; }
        public int FkDataDomain { get; set; }
        public bool? IsDefault { get; set; }

        public virtual CoordinateSystems FkCoordinateSystemNavigation { get; set; }
        public virtual DataDomains FkDataDomainNavigation { get; set; }
    }
}

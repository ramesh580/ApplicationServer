using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Axes
    {
        public Axes()
        {
            AxisReferenceSystems = new HashSet<AxisReferenceSystems>();
        }

        public int PkAxis { get; set; }
        public int FkDataDomain { get; set; }
        public int FkCoordinateSystem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double FirstPointSlopedOffset { get; set; }
        public double FirstPointHorizontalOffset { get; set; }
        public double DouglasPeuckerSimplificationTolerance { get; set; }
        public byte[] AxisPoints { get; set; }
        public string Path { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual CoordinateSystems FkCoordinateSystemNavigation { get; set; }
        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual ICollection<AxisReferenceSystems> AxisReferenceSystems { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class VerticalCoordinateSystems
    {
        public VerticalCoordinateSystems()
        {
            CoordinateSystems = new HashSet<CoordinateSystems>();
        }

        public int PkVerticalCoordinateSystem { get; set; }
        public Guid Guid { get; set; }
        public bool Protected { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? EpsgCode { get; set; }
        public string LinearUnitName { get; set; }
        public string LinearUnitCode { get; set; }
        public double LinearUnitConversionFactor { get; set; }
        public double ConversionConstant { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual ICollection<CoordinateSystems> CoordinateSystems { get; set; }
    }
}

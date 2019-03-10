using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class HorizontalGeographicCoordinateSystems
    {
        public HorizontalGeographicCoordinateSystems()
        {
            CoordinateSystems = new HashSet<CoordinateSystems>();
        }

        public int PkHorizontalGeographicCoordinateSystem { get; set; }
        public string Name { get; set; }
        public int Srid { get; set; }
        public int EpsgCode { get; set; }
        public string Wkt { get; set; }
        public string LinearUnitName { get; set; }
        public string Proj4Definition { get; set; }
        public string AngularUnitName { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual ICollection<CoordinateSystems> CoordinateSystems { get; set; }
    }
}

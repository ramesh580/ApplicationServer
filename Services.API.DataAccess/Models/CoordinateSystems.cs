using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class CoordinateSystems
    {
        public CoordinateSystems()
        {
            AssignedCoordinateSystems = new HashSet<AssignedCoordinateSystems>();
            Axes = new HashSet<Axes>();
            Dems = new HashSet<Dems>();
            Features = new HashSet<Features>();
            MapFileSets = new HashSet<MapFileSets>();
        }

        public int PkCoordinateSystem { get; set; }
        public int? FkHorizontalGeographicCoordinateSystem { get; set; }
        public int? FkVerticalCoordinateSystem { get; set; }
        public byte CoordinateSystemType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? EpsgCode { get; set; }
        public Guid Guid { get; set; }
        public bool Protected { get; set; }
        public string Proj4Definition { get; set; }
        public string LinearUnitName { get; set; }
        public byte UnitSystem { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual HorizontalGeographicCoordinateSystems FkHorizontalGeographicCoordinateSystemNavigation { get; set; }
        public virtual VerticalCoordinateSystems FkVerticalCoordinateSystemNavigation { get; set; }
        public virtual ICollection<AssignedCoordinateSystems> AssignedCoordinateSystems { get; set; }
        public virtual ICollection<Axes> Axes { get; set; }
        public virtual ICollection<Dems> Dems { get; set; }
        public virtual ICollection<Features> Features { get; set; }
        public virtual ICollection<MapFileSets> MapFileSets { get; set; }
    }
}

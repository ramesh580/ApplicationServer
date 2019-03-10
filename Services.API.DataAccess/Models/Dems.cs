using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Dems
    {
        public Dems()
        {
            DemTiles = new HashSet<DemTiles>();
        }

        public int PkDem { get; set; }
        public int FkCoordinateSystem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SequenceNumber { get; set; }
        public double? LowerLeftX { get; set; }
        public double? LowerLeftY { get; set; }
        public double? CellSize { get; set; }
        public int? Rows { get; set; }
        public int? Columns { get; set; }
        public int? TileSize { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual CoordinateSystems FkCoordinateSystemNavigation { get; set; }
        public virtual ICollection<DemTiles> DemTiles { get; set; }
    }
}

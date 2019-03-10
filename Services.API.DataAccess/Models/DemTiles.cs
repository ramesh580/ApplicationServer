using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class DemTiles
    {
        public int PkDemTile { get; set; }
        public int FkDem { get; set; }
        public int TileRow { get; set; }
        public int TileColumn { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public byte[] ElevationValues { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual Dems FkDemNavigation { get; set; }
    }
}

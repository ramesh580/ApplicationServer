using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class CrossSectionOutlineAssignements
    {
        public int PkCrossSectionOutlineAssignement { get; set; }
        public int FkCrossSectionOutline { get; set; }
        public int FkAxisReferenceSystem { get; set; }
        public double FromOffset { get; set; }
        public double ToOffset { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual AxisReferenceSystems FkAxisReferenceSystemNavigation { get; set; }
        public virtual CrossSectionOutlines FkCrossSectionOutlineNavigation { get; set; }
    }
}

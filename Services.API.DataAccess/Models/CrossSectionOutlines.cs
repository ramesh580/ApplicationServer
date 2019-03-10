using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class CrossSectionOutlines
    {
        public CrossSectionOutlines()
        {
            CrossSectionOutlineAssignements = new HashSet<CrossSectionOutlineAssignements>();
        }

        public int PkCrossSectionOutline { get; set; }
        public int FkDataDomain { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ReferencePoint1Name { get; set; }
        public double ReferencePoint1X { get; set; }
        public double ReferencePoint1Y { get; set; }
        public string ReferencePoint2Name { get; set; }
        public double ReferencePoint2X { get; set; }
        public double ReferencePoint2Y { get; set; }
        public double Circumference { get; set; }
        public double Area { get; set; }
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public string Path { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual ICollection<CrossSectionOutlineAssignements> CrossSectionOutlineAssignements { get; set; }
    }
}

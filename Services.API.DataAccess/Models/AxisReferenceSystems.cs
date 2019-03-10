using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AxisReferenceSystems
    {
        public AxisReferenceSystems()
        {
            CrossSectionOutlineAssignements = new HashSet<CrossSectionOutlineAssignements>();
            DataDomains = new HashSet<DataDomains>();
            Features = new HashSet<Features>();
            MappingTemplateParts = new HashSet<MappingTemplateParts>();
        }

        public int PkAxisReferenceSystem { get; set; }
        public int FkAxis { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double AxisOriginOffset { get; set; }
        public bool DirectionInverted { get; set; }
        public bool MeasurementModeHorizontal { get; set; }
        public double OffsetConversionFactor { get; set; }
        public string OffsetUnit { get; set; }
        public double LcsConversionFactor { get; set; }
        public string LcsUnit { get; set; }
        public double AdditiveConstant { get; set; }
        public double? Length { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }
        public double MappingTemplateMaximumWidthLeft { get; set; }
        public double MappingTemplateMaximumWidthRight { get; set; }

        public virtual Axes FkAxisNavigation { get; set; }
        public virtual ICollection<CrossSectionOutlineAssignements> CrossSectionOutlineAssignements { get; set; }
        public virtual ICollection<DataDomains> DataDomains { get; set; }
        public virtual ICollection<Features> Features { get; set; }
        public virtual ICollection<MappingTemplateParts> MappingTemplateParts { get; set; }
    }
}

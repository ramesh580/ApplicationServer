using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MappingTemplateParts
    {
        public MappingTemplateParts()
        {
            MappingTemplateGeometries = new HashSet<MappingTemplateGeometries>();
        }

        public int PkMappingTemplatePart { get; set; }
        public int FkAxisReferenceSystem { get; set; }
        public byte PartType { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual AxisReferenceSystems FkAxisReferenceSystemNavigation { get; set; }
        public virtual ICollection<MappingTemplateGeometries> MappingTemplateGeometries { get; set; }
    }
}

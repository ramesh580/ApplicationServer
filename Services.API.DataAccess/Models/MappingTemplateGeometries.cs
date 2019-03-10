using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MappingTemplateGeometries
    {
        public int PkMappingTemplateGeometry { get; set; }
        public int FkMappingTemplatePart { get; set; }
        public string Label { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual MappingTemplateParts FkMappingTemplatePartNavigation { get; set; }
    }
}

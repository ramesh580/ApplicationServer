using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class GeometryPropertyValues
    {
        public long PkGeometryPropertyValue { get; set; }
        public long FkPropertyStructureInstance { get; set; }
        public int FkProperty { get; set; }

        public virtual Properties FkPropertyNavigation { get; set; }
        public virtual PropertyStructureInstances FkPropertyStructureInstanceNavigation { get; set; }
    }
}

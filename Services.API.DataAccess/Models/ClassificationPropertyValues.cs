using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ClassificationPropertyValues
    {
        public long PkClassificationPropertyValue { get; set; }
        public long FkPropertyStructureInstance { get; set; }
        public int FkProperty { get; set; }
        public int? FkClassificationElement { get; set; }

        public virtual ClassificationElements FkClassificationElementNavigation { get; set; }
        public virtual Properties FkPropertyNavigation { get; set; }
        public virtual PropertyStructureInstances FkPropertyStructureInstanceNavigation { get; set; }
    }
}

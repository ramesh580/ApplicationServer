using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class BinaryPropertyValues
    {
        public long PkBinaryPropertyValue { get; set; }
        public long FkPropertyStructureInstance { get; set; }
        public int FkProperty { get; set; }

        public virtual Properties FkPropertyNavigation { get; set; }
        public virtual PropertyStructureInstances FkPropertyStructureInstanceNavigation { get; set; }
        public virtual FileReferences FileReferences { get; set; }
    }
}

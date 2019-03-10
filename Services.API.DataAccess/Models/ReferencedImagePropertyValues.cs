using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ReferencedImagePropertyValues
    {
        public ReferencedImagePropertyValues()
        {
            FileReferences = new HashSet<FileReferences>();
        }

        public long PkReferencedImagePropertyValue { get; set; }
        public long FkPropertyStructureInstance { get; set; }
        public int FkProperty { get; set; }
        public string ReferencingInformation { get; set; }

        public virtual Properties FkPropertyNavigation { get; set; }
        public virtual PropertyStructureInstances FkPropertyStructureInstanceNavigation { get; set; }
        public virtual ICollection<FileReferences> FileReferences { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FeatureLinkPropertyValues
    {
        public long PkFeatureLinkPropertyValue { get; set; }
        public long FkPropertyStructureInstance { get; set; }
        public int FkProperty { get; set; }
        public int? FkFeature { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual Properties FkPropertyNavigation { get; set; }
        public virtual PropertyStructureInstances FkPropertyStructureInstanceNavigation { get; set; }
    }
}

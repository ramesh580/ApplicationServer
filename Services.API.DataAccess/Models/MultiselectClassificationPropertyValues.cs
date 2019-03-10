using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MultiselectClassificationPropertyValues
    {
        public MultiselectClassificationPropertyValues()
        {
            MultiselectClassificationPropertyValueSelections = new HashSet<MultiselectClassificationPropertyValueSelections>();
        }

        public long PkMultiselectClassificationPropertyValue { get; set; }
        public int FkProperty { get; set; }
        public long FkPropertyStructureInstance { get; set; }

        public virtual Properties FkPropertyNavigation { get; set; }
        public virtual PropertyStructureInstances FkPropertyStructureInstanceNavigation { get; set; }
        public virtual ICollection<MultiselectClassificationPropertyValueSelections> MultiselectClassificationPropertyValueSelections { get; set; }
    }
}

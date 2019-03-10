using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MultiselectClassificationPropertyValueSelections
    {
        public long PkMultiselectClassificationPropertyValueSelection { get; set; }
        public long? FkMultiselectClassificationPropertyValue { get; set; }
        public int FkClassificationElement { get; set; }

        public virtual ClassificationElements FkClassificationElementNavigation { get; set; }
        public virtual MultiselectClassificationPropertyValues FkMultiselectClassificationPropertyValueNavigation { get; set; }
    }
}

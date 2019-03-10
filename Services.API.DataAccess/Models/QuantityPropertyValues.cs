using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class QuantityPropertyValues
    {
        public long PkQuanityPropertyValue { get; set; }
        public long FkPropertyStructureInstance { get; set; }
        public int FkProperty { get; set; }
        public int? FkAvailableUnit { get; set; }
        public double? Value { get; set; }

        public virtual AvailableUnits FkAvailableUnitNavigation { get; set; }
        public virtual Properties FkPropertyNavigation { get; set; }
        public virtual PropertyStructureInstances FkPropertyStructureInstanceNavigation { get; set; }
    }
}

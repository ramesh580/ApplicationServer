using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class DerivedQuantityParts
    {
        public DerivedQuantityParts()
        {
            AvailableUnitParts = new HashSet<AvailableUnitParts>();
        }

        public int PkDerivedQuantityPart { get; set; }
        public string IntName { get; set; }
        public int Exponent { get; set; }
        public int FkQuantityTypeIsPartOf { get; set; }
        public int FkQuantityTypeBaseType { get; set; }
        public Guid DerivedQuantityPartGuid { get; set; }

        public virtual QuantityTypes FkQuantityTypeBaseTypeNavigation { get; set; }
        public virtual QuantityTypes FkQuantityTypeIsPartOfNavigation { get; set; }
        public virtual ICollection<AvailableUnitParts> AvailableUnitParts { get; set; }
    }
}

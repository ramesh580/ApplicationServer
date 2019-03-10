using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Units
    {
        public Units()
        {
            AvailableUnitParts = new HashSet<AvailableUnitParts>();
        }

        public int PkUnit { get; set; }
        public Guid? UnitGuid { get; set; }
        public int FkQuantityType { get; set; }
        public byte UnitSystem { get; set; }
        public bool BaseUnit { get; set; }
        public string IntName { get; set; }
        public double ToBaseInitialAddend { get; set; }
        public double ToBaseMultiplicand { get; set; }
        public double ToBaseDivisor { get; set; }
        public double ToBaseFinalAddend { get; set; }

        public virtual QuantityTypes FkQuantityTypeNavigation { get; set; }
        public virtual ICollection<AvailableUnitParts> AvailableUnitParts { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AvailableUnits
    {
        public AvailableUnits()
        {
            AvailableUnitParts = new HashSet<AvailableUnitParts>();
            QuantityPropertyValues = new HashSet<QuantityPropertyValues>();
        }

        public int PkAvailableUnit { get; set; }
        public Guid AvailableUnitGuid { get; set; }
        public int FkQuantityType { get; set; }
        public string IntName { get; set; }
        public short SequenceNumber { get; set; }
        public Guid NameGuid { get; set; }
        public byte AvailableUnitVersion { get; set; }
        public Guid SymbolGuid { get; set; }
        public double PrefixMultiplicant { get; set; }
        public string IdentifyingName { get; set; }

        public virtual QuantityTypes FkQuantityTypeNavigation { get; set; }
        public virtual ICollection<AvailableUnitParts> AvailableUnitParts { get; set; }
        public virtual ICollection<QuantityPropertyValues> QuantityPropertyValues { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class QuantityTypes
    {
        public QuantityTypes()
        {
            AvailableUnits = new HashSet<AvailableUnits>();
            DerivedQuantityPartsFkQuantityTypeBaseTypeNavigation = new HashSet<DerivedQuantityParts>();
            DerivedQuantityPartsFkQuantityTypeIsPartOfNavigation = new HashSet<DerivedQuantityParts>();
            Properties = new HashSet<Properties>();
            UnitSystemConversionSettings = new HashSet<UnitSystemConversionSettings>();
            Units = new HashSet<Units>();
        }

        public int PkQuantityType { get; set; }
        public Guid QuantityTypeGuid { get; set; }
        public Guid NameGuid { get; set; }
        public Guid? DescriptionGuid { get; set; }
        public bool IsBaseQuantity { get; set; }
        public string Symbol { get; set; }
        public string DimensionSymbol { get; set; }
        public double ConversionInitialAddend { get; set; }
        public double ConversionMultiplicand { get; set; }
        public double ConversionDivisor { get; set; }
        public double ConversionFinalAddend { get; set; }
        public byte QuantityTypeVersion { get; set; }

        public virtual ICollection<AvailableUnits> AvailableUnits { get; set; }
        public virtual ICollection<DerivedQuantityParts> DerivedQuantityPartsFkQuantityTypeBaseTypeNavigation { get; set; }
        public virtual ICollection<DerivedQuantityParts> DerivedQuantityPartsFkQuantityTypeIsPartOfNavigation { get; set; }
        public virtual ICollection<Properties> Properties { get; set; }
        public virtual ICollection<UnitSystemConversionSettings> UnitSystemConversionSettings { get; set; }
        public virtual ICollection<Units> Units { get; set; }
    }
}

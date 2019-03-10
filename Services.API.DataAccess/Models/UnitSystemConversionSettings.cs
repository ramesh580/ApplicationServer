using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class UnitSystemConversionSettings
    {
        public int PkUnitSystemConversionSetting { get; set; }
        public int FkQuantityType { get; set; }
        public byte UnitSystem { get; set; }
        public double ConversionInitialAddend { get; set; }
        public double ConversionMultiplicand { get; set; }
        public double ConversionDivisor { get; set; }
        public double ConversionFinalAddend { get; set; }

        public virtual QuantityTypes FkQuantityTypeNavigation { get; set; }
    }
}

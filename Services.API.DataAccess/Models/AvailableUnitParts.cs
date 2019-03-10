using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AvailableUnitParts
    {
        public int PkAvailabileUnitPart { get; set; }
        public int? FkUnit { get; set; }
        public int? FkAvailableUnit { get; set; }
        public int? FkDerivedQuantityPart { get; set; }

        public virtual AvailableUnits FkAvailableUnitNavigation { get; set; }
        public virtual DerivedQuantityParts FkDerivedQuantityPartNavigation { get; set; }
        public virtual Units FkUnitNavigation { get; set; }
    }
}

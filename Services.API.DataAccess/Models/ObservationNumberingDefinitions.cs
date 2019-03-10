using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ObservationNumberingDefinitions
    {
        public ObservationNumberingDefinitions()
        {
            Features = new HashSet<Features>();
        }

        public int PkObservationNumberingDefinition { get; set; }
        public int FkDataDomain { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Seed { get; set; }
        public short Increment { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual ICollection<Features> Features { get; set; }
    }
}

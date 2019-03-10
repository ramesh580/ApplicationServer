using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Attachements
    {
        public int PkAttachement { get; set; }
        public int? FkFeature { get; set; }
        public long? FkObservation { get; set; }
        public short SequenceNumber { get; set; }
        public byte? TagNo { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }
        public Guid? PropertyStructureInstanceGuid { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual Observations FkObservationNavigation { get; set; }
        public virtual FileReferences FileReferences { get; set; }
    }
}

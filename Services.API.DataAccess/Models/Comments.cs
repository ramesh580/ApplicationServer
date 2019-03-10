using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Comments
    {
        public int PkComment { get; set; }
        public int FkUser { get; set; }
        public int? FkFeature { get; set; }
        public long? FkObservation { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset? LastUpdate { get; set; }
        public DateTimeOffset? RevokedOn { get; set; }
        public string RevocationReason { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }
        public Guid? PropertyStructureInstanceGuid { get; set; }
        public bool ImportedComment { get; set; }
        public string OriginallyCommentedBy { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual Observations FkObservationNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
    }
}

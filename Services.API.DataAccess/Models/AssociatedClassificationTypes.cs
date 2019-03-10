using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AssociatedClassificationTypes
    {
        public int PkAssociatedClassificationType { get; set; }
        public int FkFeatureType { get; set; }
        public Guid ClassificationTypeGuid { get; set; }

        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
    }
}

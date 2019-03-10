using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class TaxonomyTermAssignments
    {
        public int PkTaxonomyTermAssignment { get; set; }
        public int FkFeature { get; set; }
        public int FkTaxonomyTerm { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual TaxonomyTerms FkTaxonomyTermNavigation { get; set; }
    }
}

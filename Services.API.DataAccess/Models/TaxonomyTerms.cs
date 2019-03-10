using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class TaxonomyTerms
    {
        public TaxonomyTerms()
        {
            TaxonomyTermAssignments = new HashSet<TaxonomyTermAssignments>();
        }

        public int PkTaxonomyTerm { get; set; }
        public int FkDataDomain { get; set; }
        public int FkTaxonomy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual Taxonomies FkTaxonomyNavigation { get; set; }
        public virtual ICollection<TaxonomyTermAssignments> TaxonomyTermAssignments { get; set; }
    }
}

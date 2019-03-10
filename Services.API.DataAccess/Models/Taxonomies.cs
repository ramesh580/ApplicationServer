using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Taxonomies
    {
        public Taxonomies()
        {
            TaxonomyTerms = new HashSet<TaxonomyTerms>();
        }

        public int PkTaxonomy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TaxonomyTerms> TaxonomyTerms { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AliasSchemes
    {
        public AliasSchemes()
        {
            AliasNames = new HashSet<AliasNames>();
        }

        public int PkAliasScheme { get; set; }
        public int FkDataDomain { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual ICollection<AliasNames> AliasNames { get; set; }
    }
}

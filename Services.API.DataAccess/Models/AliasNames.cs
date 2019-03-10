using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AliasNames
    {
        public int PkAliasName { get; set; }
        public int FkAliasScheme { get; set; }
        public int FkFeature { get; set; }
        public string Name { get; set; }

        public virtual AliasSchemes FkAliasSchemeNavigation { get; set; }
        public virtual Features FkFeatureNavigation { get; set; }
    }
}

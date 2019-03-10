using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class HiddenClassificationElements
    {
        public int PkHiddenClassificationElement { get; set; }
        public int FkDataDomain { get; set; }
        public int FkClassificationElement { get; set; }

        public virtual ClassificationElements FkClassificationElementNavigation { get; set; }
        public virtual DataDomains FkDataDomainNavigation { get; set; }
    }
}

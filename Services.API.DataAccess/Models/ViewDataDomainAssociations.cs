using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ViewDataDomainAssociations
    {
        public int PkViewDataDomainAssociation { get; set; }
        public int FkView { get; set; }
        public int FkDataDomain { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual Views FkViewNavigation { get; set; }
    }
}

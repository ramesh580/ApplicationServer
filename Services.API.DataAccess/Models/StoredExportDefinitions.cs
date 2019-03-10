using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class StoredExportDefinitions
    {
        public int PkStoredExportDefinition { get; set; }
        public int? FkDataDomain { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FormatDetails { get; set; }
        public string GlobalSettings { get; set; }
        public int? FkUserPrivateFor { get; set; }
        public string Path { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual Users FkUserPrivateForNavigation { get; set; }
        public virtual FileReferences FileReferences { get; set; }
    }
}

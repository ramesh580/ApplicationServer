using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ImportSessions
    {
        public ImportSessions()
        {
            Features = new HashSet<Features>();
            ImportedFiles = new HashSet<ImportedFiles>();
            Observations = new HashSet<Observations>();
        }

        public int PkImportSession { get; set; }
        public int? FkStoredImportDefinition { get; set; }
        public int FkUser { get; set; }
        public string Description { get; set; }
        public string ImportLog { get; set; }
        public byte SuccessStatus { get; set; }
        public DateTimeOffset? Started { get; set; }
        public DateTimeOffset? Ended { get; set; }
        public string DataSource { get; set; }
        public string GlobalSettings { get; set; }
        public string Name { get; set; }
        public string FormatSettings { get; set; }

        public virtual StoredImportDefinitions FkStoredImportDefinitionNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
        public virtual ICollection<Features> Features { get; set; }
        public virtual ICollection<ImportedFiles> ImportedFiles { get; set; }
        public virtual ICollection<Observations> Observations { get; set; }
    }
}

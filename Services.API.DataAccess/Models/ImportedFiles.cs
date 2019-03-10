using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ImportedFiles
    {
        public int PkImportSessionFile { get; set; }
        public int FkImportSession { get; set; }
        public string FileName { get; set; }
        public DateTimeOffset? LastModificationDate { get; set; }
        public int? FileSize { get; set; }

        public virtual ImportSessions FkImportSessionNavigation { get; set; }
        public virtual FileReferences FileReferences { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class OutputFiles
    {
        public int PkOutputFile { get; set; }
        public int FkUserOwner { get; set; }
        public byte OutputType { get; set; }
        public DateTimeOffset GenerationStartDate { get; set; }

        public virtual Users FkUserOwnerNavigation { get; set; }
        public virtual FileReferences FileReferences { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Patterns
    {
        public int PkPattern { get; set; }
        public int FkDataDomain { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte PatternType { get; set; }
        public byte[] PatternBinary { get; set; }
        public byte? PredefinedHatchPatternType { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
    }
}

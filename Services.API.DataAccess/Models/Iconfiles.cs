using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Iconfiles
    {
        public int PkIconFile { get; set; }
        public int? FkIcon { get; set; }
        public byte Size { get; set; }
        public byte[] FileBinary { get; set; }

        public virtual Icons FkIconNavigation { get; set; }
    }
}

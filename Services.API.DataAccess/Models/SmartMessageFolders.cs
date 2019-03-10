using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class SmartMessageFolders
    {
        public int PkSmartMessageFolder { get; set; }
        public int? FkUser { get; set; }
        public string Name { get; set; }
        public string FilterXml { get; set; }
        public string OrderXml { get; set; }
        public byte DeletedMessageHandling { get; set; }

        public virtual Users FkUserNavigation { get; set; }
    }
}

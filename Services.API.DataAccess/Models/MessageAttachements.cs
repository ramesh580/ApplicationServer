using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MessageAttachements
    {
        public int PkMessageAttachment { get; set; }
        public int FkMessage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Messages FkMessageNavigation { get; set; }
        public virtual FileReferences FileReferences { get; set; }
    }
}

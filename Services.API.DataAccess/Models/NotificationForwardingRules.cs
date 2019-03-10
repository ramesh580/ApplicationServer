using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class NotificationForwardingRules
    {
        public int PkNotificationForwardingRule { get; set; }
        public int FkUser { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? SeverityLevelFrom { get; set; }
        public byte? SeverityLevelTo { get; set; }
        public byte? CommunicationMethod { get; set; }

        public virtual Users FkUserNavigation { get; set; }
    }
}

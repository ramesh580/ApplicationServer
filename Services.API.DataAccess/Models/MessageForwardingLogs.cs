using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MessageForwardingLogs
    {
        public int PkMessageForwardingLog { get; set; }
        public int? FkMessageUserAssignement { get; set; }
        public byte DeliveryMedium { get; set; }
        public string DeliveryAddress { get; set; }
        public byte MessageDeliveryStatus { get; set; }
        public string MessageDeliveryLog { get; set; }

        public virtual MessageUserAssignements FkMessageUserAssignementNavigation { get; set; }
    }
}

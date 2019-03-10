using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MessageExternalRecipients
    {
        public int PkMessageExternalRecipient { get; set; }
        public int FkMessage { get; set; }
        public byte? DeliveryMedium { get; set; }
        public string DeliverryAddress { get; set; }

        public virtual Messages FkMessageNavigation { get; set; }
    }
}

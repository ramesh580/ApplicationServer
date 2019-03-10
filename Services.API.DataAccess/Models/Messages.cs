using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Messages
    {
        public Messages()
        {
            MessageAttachements = new HashSet<MessageAttachements>();
            MessageExternalRecipients = new HashSet<MessageExternalRecipients>();
            MessageUserAssignements = new HashSet<MessageUserAssignements>();
        }

        public int PkMessage { get; set; }
        public int FkUserSender { get; set; }
        public DateTimeOffset SendDate { get; set; }
        public string Subject { get; set; }
        public byte Severity { get; set; }
        public byte AcknowledgementStatus { get; set; }
        public DateTimeOffset? AcknowledgementDueDate { get; set; }
        public bool AcknowledgementNeeded { get; set; }
        public byte MessageDeliveryStatus { get; set; }
        public bool NofitySenderOnAcknowledgement { get; set; }
        public bool DeletedMark { get; set; }
        public string Body { get; set; }
        public string MessageDeliveryLog { get; set; }
        public byte MessageSourceContext { get; set; }

        public virtual Users FkUserSenderNavigation { get; set; }
        public virtual ICollection<MessageAttachements> MessageAttachements { get; set; }
        public virtual ICollection<MessageExternalRecipients> MessageExternalRecipients { get; set; }
        public virtual ICollection<MessageUserAssignements> MessageUserAssignements { get; set; }
    }
}

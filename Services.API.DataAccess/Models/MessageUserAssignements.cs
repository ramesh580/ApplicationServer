using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MessageUserAssignements
    {
        public MessageUserAssignements()
        {
            MessageForwardingLogs = new HashSet<MessageForwardingLogs>();
        }

        public int PkMessageUserAssignement { get; set; }
        public int FkMessage { get; set; }
        public int FkUserAssignedTo { get; set; }
        public int? FkMessageFolder { get; set; }
        public bool AcknowledgementNeeded { get; set; }
        public byte AcknowledgementStatus { get; set; }
        public DateTimeOffset? AcknowledgementDate { get; set; }
        public bool ReadMark { get; set; }
        public bool DeletedMark { get; set; }

        public virtual MessageFolders FkMessageFolderNavigation { get; set; }
        public virtual Messages FkMessageNavigation { get; set; }
        public virtual Users FkUserAssignedToNavigation { get; set; }
        public virtual ICollection<MessageForwardingLogs> MessageForwardingLogs { get; set; }
    }
}

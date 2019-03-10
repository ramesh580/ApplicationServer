using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MessageFolders
    {
        public MessageFolders()
        {
            InverseFkMessageFolderNavigation = new HashSet<MessageFolders>();
            MessageUserAssignements = new HashSet<MessageUserAssignements>();
        }

        public int PkMessageFolder { get; set; }
        public int? FkMessageFolder { get; set; }
        public int FkUser { get; set; }
        public string Name { get; set; }

        public virtual MessageFolders FkMessageFolderNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
        public virtual ICollection<MessageFolders> InverseFkMessageFolderNavigation { get; set; }
        public virtual ICollection<MessageUserAssignements> MessageUserAssignements { get; set; }
    }
}

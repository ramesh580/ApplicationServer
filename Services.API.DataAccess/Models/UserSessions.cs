using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class UserSessions
    {
        public int PkUserSession { get; set; }
        public int FkUser { get; set; }
        public int? FkAuthenticationAttempt { get; set; }
        public Guid SessionToken { get; set; }
        public DateTimeOffset SessionStart { get; set; }
        public DateTimeOffset? SessionLastUsed { get; set; }
        public DateTimeOffset? SessionEnd { get; set; }
        public byte SessionEndReason { get; set; }
        public int AllowedSessionIdleTime { get; set; }
        public string ClientInformation { get; set; }
        public byte SessionLanguage { get; set; }
        public short SessionTimeOffset { get; set; }

        public virtual AuthenticationAttempts FkAuthenticationAttemptNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
    }
}

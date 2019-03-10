using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class AuthenticationAttempts
    {
        public int PkAuthenticationAttempt { get; set; }
        public DateTimeOffset? AuthenticationTimestamp { get; set; }
        public string UsedUserName { get; set; }
        public byte ResultCode { get; set; }

        public virtual UserSessions UserSessions { get; set; }
    }
}

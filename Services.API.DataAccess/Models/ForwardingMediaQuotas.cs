using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ForwardingMediaQuotas
    {
        public int PkForwardingMediaQuota { get; set; }
        public byte MediaType { get; set; }
        public string Configuration { get; set; }
    }
}

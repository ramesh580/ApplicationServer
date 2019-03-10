using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class SingletonSettings
    {
        public int PkSingletonSetting { get; set; }
        public long DatabaseVersionNumber { get; set; }
        public byte[] License { get; set; }
        public string GlobalSettings { get; set; }
        public Guid? InstanceGuid { get; set; }
    }
}

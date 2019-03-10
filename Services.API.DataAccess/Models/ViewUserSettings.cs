using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ViewUserSettings
    {
        public int PkViewUserSetting { get; set; }
        public int FkUser { get; set; }
        public int FkView { get; set; }
        public bool HideView { get; set; }
        public byte UnitSystem { get; set; }

        public virtual Users FkUserNavigation { get; set; }
        public virtual Views FkViewNavigation { get; set; }
    }
}

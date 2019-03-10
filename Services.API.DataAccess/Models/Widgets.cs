using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Widgets
    {
        public int PkWidget { get; set; }
        public int FkWidgetsConfiguration { get; set; }
        public Guid Guid { get; set; }
        public string Configuration { get; set; }

        public virtual DashboardConfigurations FkWidgetsConfigurationNavigation { get; set; }
    }
}

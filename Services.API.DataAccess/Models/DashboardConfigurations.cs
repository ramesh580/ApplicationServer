using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class DashboardConfigurations
    {
        public DashboardConfigurations()
        {
            Widgets = new HashSet<Widgets>();
        }

        public int PkDashboardConfiguration { get; set; }
        public int? FkUser { get; set; }
        public byte NumberOfColums { get; set; }
        public string SequenceConfiguration { get; set; }

        public virtual Users FkUserNavigation { get; set; }
        public virtual ICollection<Widgets> Widgets { get; set; }
    }
}

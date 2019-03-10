using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Workspaces
    {
        public Workspaces()
        {
            WorkspaceAssociations = new HashSet<WorkspaceAssociations>();
        }

        public int PkWorkspace { get; set; }
        public int FkView { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? Type { get; set; }
        public string TypeSettings { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual Views FkViewNavigation { get; set; }
        public virtual ICollection<WorkspaceAssociations> WorkspaceAssociations { get; set; }
    }
}

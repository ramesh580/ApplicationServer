using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Views
    {
        public Views()
        {
            InverseFkViewNavigation = new HashSet<Views>();
            Privileges = new HashSet<Privileges>();
            UserFavorites = new HashSet<UserFavorites>();
            ViewDataDomainAssociations = new HashSet<ViewDataDomainAssociations>();
            ViewUserSettings = new HashSet<ViewUserSettings>();
            Workspaces = new HashSet<Workspaces>();
        }

        public int PkView { get; set; }
        public int? FkView { get; set; }
        public int? FkUserPersonalFor { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte DeletedFeaturesHandling { get; set; }
        public byte DeletedObservationsHandling { get; set; }
        public bool? Executable { get; set; }
        public byte UnitSystem { get; set; }
        public bool Hidden { get; set; }
        public string FilterXml { get; set; }
        public string OrderXml { get; set; }
        public bool BreakPermissionPropagation { get; set; }
        public int ForegroundColor { get; set; }
        public int SequenceNumber { get; set; }
        public byte IconIndex { get; set; }
        public bool? AssociateWithAllDataDomains { get; set; }

        public virtual Users FkUserPersonalForNavigation { get; set; }
        public virtual Views FkViewNavigation { get; set; }
        public virtual ICollection<Views> InverseFkViewNavigation { get; set; }
        public virtual ICollection<Privileges> Privileges { get; set; }
        public virtual ICollection<UserFavorites> UserFavorites { get; set; }
        public virtual ICollection<ViewDataDomainAssociations> ViewDataDomainAssociations { get; set; }
        public virtual ICollection<ViewUserSettings> ViewUserSettings { get; set; }
        public virtual ICollection<Workspaces> Workspaces { get; set; }
    }
}

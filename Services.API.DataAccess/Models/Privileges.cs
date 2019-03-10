using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Privileges
    {
        public int PkPrivilege { get; set; }
        public int? FkUser { get; set; }
        public int? FkUserGroup { get; set; }
        public int? FkDataDomain { get; set; }
        public int? FkFeature { get; set; }
        public int? FkView { get; set; }
        public byte? SystemInternalPermissionObject { get; set; }
        public byte PermissionEnumValue { get; set; }
        public int? FkFeatureType { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual Features FkFeatureNavigation { get; set; }
        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
        public virtual UserGroups FkUserGroupNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
        public virtual Views FkViewNavigation { get; set; }
    }
}

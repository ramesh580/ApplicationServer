using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class PropertyConfigurations
    {
        public int PkPropertyConfiguration { get; set; }
        public int FkPropertyStructureConfiguration { get; set; }
        public int FkProperty { get; set; }
        public bool? Mandatory { get; set; }
        public string DisplayConfiguration { get; set; }
        public string DefaultValue { get; set; }
        public string ValidationRule { get; set; }
        public string VisualAppearance { get; set; }

        public virtual Properties FkPropertyNavigation { get; set; }
        public virtual PropertyStructureConfigurations FkPropertyStructureConfigurationNavigation { get; set; }
    }
}

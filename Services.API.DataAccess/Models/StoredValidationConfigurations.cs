using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class StoredValidationConfigurations
    {
        public StoredValidationConfigurations()
        {
            ValidationRuns = new HashSet<ValidationRuns>();
        }

        public int PkStoredValidationConfiguration { get; set; }
        public int FkUser { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ValidationConfiguration { get; set; }

        public virtual Users FkUserNavigation { get; set; }
        public virtual ICollection<ValidationRuns> ValidationRuns { get; set; }
    }
}

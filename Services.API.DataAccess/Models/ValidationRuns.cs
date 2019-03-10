using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ValidationRuns
    {
        public ValidationRuns()
        {
            ValidationResults = new HashSet<ValidationResults>();
        }

        public int PkValidationRun { get; set; }
        public int FkUser { get; set; }
        public int? FkQueuedJob { get; set; }
        public int? FkStoredValidationConfiguration { get; set; }
        public string ValidationConfiguration { get; set; }
        public byte Status { get; set; }
        public DateTimeOffset StartedAt { get; set; }
        public DateTimeOffset? FinishedAt { get; set; }
        public bool Locked { get; set; }
        public string Name { get; set; }

        public virtual QueuedJobs FkQueuedJobNavigation { get; set; }
        public virtual StoredValidationConfigurations FkStoredValidationConfigurationNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
        public virtual ICollection<ValidationResults> ValidationResults { get; set; }
    }
}

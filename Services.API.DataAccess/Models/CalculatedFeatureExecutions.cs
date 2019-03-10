using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class CalculatedFeatureExecutions
    {
        public int PkCalculatedFeatureExecution { get; set; }
        public int FkFeature { get; set; }
        public int FkQueuedJob { get; set; }
        public DateTimeOffset ExecutionStart { get; set; }
        public DateTimeOffset? AlgorithmStart { get; set; }
        public DateTimeOffset? ExecutionEnd { get; set; }
        public byte SuccessStatus { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual QueuedJobs FkQueuedJobNavigation { get; set; }
    }
}

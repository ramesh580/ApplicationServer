using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class QueuedJobs
    {
        public QueuedJobs()
        {
            CalculatedFeatureExecutions = new HashSet<CalculatedFeatureExecutions>();
            InverseFkQueuedJobPredecessorNavigation = new HashSet<QueuedJobs>();
            ValidationRuns = new HashSet<ValidationRuns>();
        }

        public int PkQueuedJob { get; set; }
        public int? FkUserJobowner { get; set; }
        public int? FkQueuedJobPredecessor { get; set; }
        public int? FkStoredJobDefinition { get; set; }
        public short JobType { get; set; }
        public string ExecutionParameter { get; set; }
        public byte JobStatus { get; set; }
        public DateTimeOffset TriggeredAt { get; set; }
        public DateTimeOffset? ExecutedAt { get; set; }
        public DateTimeOffset? FinishedAt { get; set; }
        public byte ExecutionPriority { get; set; }
        public byte ThreadSchedulingPriority { get; set; }
        public byte SuccessStatus { get; set; }
        public string JobLog { get; set; }
        public DateTimeOffset JobStatusLastChangedAt { get; set; }
        public bool TriggerSuccessorJobs { get; set; }
        public string JobResult { get; set; }

        public virtual QueuedJobs FkQueuedJobPredecessorNavigation { get; set; }
        public virtual StoredJobDefinitions FkStoredJobDefinitionNavigation { get; set; }
        public virtual Users FkUserJobownerNavigation { get; set; }
        public virtual ICollection<CalculatedFeatureExecutions> CalculatedFeatureExecutions { get; set; }
        public virtual ICollection<QueuedJobs> InverseFkQueuedJobPredecessorNavigation { get; set; }
        public virtual ICollection<ValidationRuns> ValidationRuns { get; set; }
    }
}

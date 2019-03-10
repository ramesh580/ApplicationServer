using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class StoredJobDefinitions
    {
        public StoredJobDefinitions()
        {
            EventSchedules = new HashSet<EventSchedules>();
            InverseFkStoredJobDefinitionPredecessorNavigation = new HashSet<StoredJobDefinitions>();
            QueuedJobs = new HashSet<QueuedJobs>();
        }

        public int PkStoredJobDefinition { get; set; }
        public int? FkStoredJobDefinitionPredecessor { get; set; }
        public int FkUser { get; set; }
        public string Name { get; set; }
        public short JobType { get; set; }
        public string Description { get; set; }
        public string JobSettings { get; set; }
        public byte ExecutionPriority { get; set; }
        public byte ThreadSchedulingPriority { get; set; }

        public virtual StoredJobDefinitions FkStoredJobDefinitionPredecessorNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
        public virtual ICollection<EventSchedules> EventSchedules { get; set; }
        public virtual ICollection<StoredJobDefinitions> InverseFkStoredJobDefinitionPredecessorNavigation { get; set; }
        public virtual ICollection<QueuedJobs> QueuedJobs { get; set; }
    }
}

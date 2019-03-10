using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Observations
    {
        public Observations()
        {
            AppliedObservationTags = new HashSet<AppliedObservationTags>();
            ApprovalWorkflowAssignements = new HashSet<ApprovalWorkflowAssignements>();
            Attachements = new HashSet<Attachements>();
            Comments = new HashSet<Comments>();
            FeatureLinks = new HashSet<FeatureLinks>();
            ObservationAlarms = new HashSet<ObservationAlarms>();
            PropertyStructureInstancesFkObservationFlatNavigation = new HashSet<PropertyStructureInstances>();
            PropertyStructureInstancesFkObservationSensorConfigurationFlatNavigation = new HashSet<PropertyStructureInstances>();
            PropertyStructureInstancesFkObservationSensorConfigurationNavigation = new HashSet<PropertyStructureInstances>();
            Urls = new HashSet<Urls>();
        }

        public long PkObservation { get; set; }
        public int FkFeature { get; set; }
        public int? FkSensor { get; set; }
        public bool Erroneous { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public DateTimeOffset SamplingTimestamp { get; set; }
        public DateTimeOffset? ResultTimestamp { get; set; }
        public byte ApprovalStatus { get; set; }
        public DateTimeOffset? LastUpdate { get; set; }
        public int? FkImportSession { get; set; }
        public bool HasAssociatedData { get; set; }
        public int? ObservationNumber { get; set; }
        public int? FkUserLastUpdate { get; set; }

        public virtual Features FkFeatureNavigation { get; set; }
        public virtual ImportSessions FkImportSessionNavigation { get; set; }
        public virtual Sensors FkSensorNavigation { get; set; }
        public virtual Users FkUserLastUpdateNavigation { get; set; }
        public virtual AxisOffsetSpatialData AxisOffsetSpatialData { get; set; }
        public virtual GeographicSpatialData GeographicSpatialData { get; set; }
        public virtual GeometricSpatialData GeometricSpatialData { get; set; }
        public virtual PropertyStructureInstances PropertyStructureInstancesFkObservationNavigation { get; set; }
        public virtual ICollection<AppliedObservationTags> AppliedObservationTags { get; set; }
        public virtual ICollection<ApprovalWorkflowAssignements> ApprovalWorkflowAssignements { get; set; }
        public virtual ICollection<Attachements> Attachements { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<FeatureLinks> FeatureLinks { get; set; }
        public virtual ICollection<ObservationAlarms> ObservationAlarms { get; set; }
        public virtual ICollection<PropertyStructureInstances> PropertyStructureInstancesFkObservationFlatNavigation { get; set; }
        public virtual ICollection<PropertyStructureInstances> PropertyStructureInstancesFkObservationSensorConfigurationFlatNavigation { get; set; }
        public virtual ICollection<PropertyStructureInstances> PropertyStructureInstancesFkObservationSensorConfigurationNavigation { get; set; }
        public virtual ICollection<Urls> Urls { get; set; }
    }
}

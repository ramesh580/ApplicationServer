using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Features
    {
        public Features()
        {
            AliasNames = new HashSet<AliasNames>();
            AppliedFeatureTags = new HashSet<AppliedFeatureTags>();
            ApprovalWorkflowsFkFeatureNavigation = new HashSet<ApprovalWorkflows>();
            ApprovalWorkflowsFkFeatureObservationNavigation = new HashSet<ApprovalWorkflows>();
            Attachements = new HashSet<Attachements>();
            CalculatedFeatureExecutions = new HashSet<CalculatedFeatureExecutions>();
            Comments = new HashSet<Comments>();
            ContainerContextSettings = new HashSet<ContainerContextSettings>();
            DataDomains = new HashSet<DataDomains>();
            FeatureAlgorithmMembersFkFeatureCalculatedFeatureNavigation = new HashSet<FeatureAlgorithmMembers>();
            FeatureAlgorithmMembersFkFeatureSourceFeatureNavigation = new HashSet<FeatureAlgorithmMembers>();
            FeatureGroupMembersFkFeatureGroupNavigation = new HashSet<FeatureGroupMembers>();
            FeatureGroupMembersFkFeatureMemberNavigation = new HashSet<FeatureGroupMembers>();
            FeatureLinkPropertyValues = new HashSet<FeatureLinkPropertyValues>();
            FeatureLinksFkFeatureDestinationNavigation = new HashSet<FeatureLinks>();
            FeatureLinksFkFeatureNavigation = new HashSet<FeatureLinks>();
            FeatureNetworkMembersFkFeatureMemberNavigation = new HashSet<FeatureNetworkMembers>();
            FeatureNetworkMembersFkFeatureNetworkNavigation = new HashSet<FeatureNetworkMembers>();
            FeatureSetMembers = new HashSet<FeatureSetMembers>();
            InverseFkFeatureCalculationFeatureDataSourceNavigation = new HashSet<Features>();
            InverseFkFeatureContainerNavigation = new HashSet<Features>();
            InverseFkFeatureInstantiatedFromNavigation = new HashSet<Features>();
            ObservationPlanViolations = new HashSet<ObservationPlanViolations>();
            Observations = new HashSet<Observations>();
            Privileges = new HashSet<Privileges>();
            PropertyStructureConfigurationContexts = new HashSet<PropertyStructureConfigurationContexts>();
            PropertyStructureInstancesFkFeatureFlatNavigation = new HashSet<PropertyStructureInstances>();
            TaxonomyTermAssignments = new HashSet<TaxonomyTermAssignments>();
            Urls = new HashSet<Urls>();
        }

        public int PkFeature { get; set; }
        public int FkFeatureType { get; set; }
        public int FkDataDomain { get; set; }
        public int? FkFeatureSubtype { get; set; }
        public int? FkFeatureContainer { get; set; }
        public int? FkFeatureCalculationFeatureDataSource { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte ApprovalStatus { get; set; }
        public bool Deleted { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public int? FkAxisReferenceSystem { get; set; }
        public bool CalculatedFeature { get; set; }
        public bool InstantiatingCalculatedFeature { get; set; }
        public int? FkFeatureInstantiatedFrom { get; set; }
        public string CalculationAlgorithm { get; set; }
        public int? FkUserCalculationAlgorithmOwner { get; set; }
        public int AlgorithmExpansionIfOlderThan { get; set; }
        public byte IncrementalRecalculationOption { get; set; }
        public bool CopyExtendedDataOnExecution { get; set; }
        public bool CopySpatialDataOnExecution { get; set; }
        public string ExecutionMemory { get; set; }
        public DateTimeOffset? LatestObservationPurging { get; set; }
        public DateTimeOffset? LastAlgorithmChange { get; set; }
        public DateTimeOffset? LastUpdate { get; set; }
        public bool? BeingSpied { get; set; }
        public int? FkImportSession { get; set; }
        public int? FkCoordinateSystem { get; set; }
        public int ContainerSequenceNumber { get; set; }
        public int? FkSensorDefault { get; set; }
        public bool UseContainerLso { get; set; }
        public byte DataSouce { get; set; }
        public string DataSourceSetting { get; set; }
        public short? ConnectorType { get; set; }
        public float? ContainerLsooffsetA { get; set; }
        public float? ContainerLsooffsetB { get; set; }
        public float? ContainerLsooffsetC { get; set; }
        public bool HasAssociatedData { get; set; }
        public int? FkObservationNumberingDefinition { get; set; }
        public Guid Guid { get; set; }

        public virtual AxisReferenceSystems FkAxisReferenceSystemNavigation { get; set; }
        public virtual CoordinateSystems FkCoordinateSystemNavigation { get; set; }
        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual Features FkFeatureCalculationFeatureDataSourceNavigation { get; set; }
        public virtual Features FkFeatureContainerNavigation { get; set; }
        public virtual Features FkFeatureInstantiatedFromNavigation { get; set; }
        public virtual FeatureSubtypes FkFeatureSubtypeNavigation { get; set; }
        public virtual FeatureTypes FkFeatureTypeNavigation { get; set; }
        public virtual ImportSessions FkImportSessionNavigation { get; set; }
        public virtual ObservationNumberingDefinitions FkObservationNumberingDefinitionNavigation { get; set; }
        public virtual Sensors FkSensorDefaultNavigation { get; set; }
        public virtual Users FkUserCalculationAlgorithmOwnerNavigation { get; set; }
        public virtual AxisOffsetSpatialData AxisOffsetSpatialData { get; set; }
        public virtual GeographicSpatialData GeographicSpatialData { get; set; }
        public virtual GeometricSpatialData GeometricSpatialData { get; set; }
        public virtual PropertyStructureInstances PropertyStructureInstancesFkFeatureNavigation { get; set; }
        public virtual ICollection<AliasNames> AliasNames { get; set; }
        public virtual ICollection<AppliedFeatureTags> AppliedFeatureTags { get; set; }
        public virtual ICollection<ApprovalWorkflows> ApprovalWorkflowsFkFeatureNavigation { get; set; }
        public virtual ICollection<ApprovalWorkflows> ApprovalWorkflowsFkFeatureObservationNavigation { get; set; }
        public virtual ICollection<Attachements> Attachements { get; set; }
        public virtual ICollection<CalculatedFeatureExecutions> CalculatedFeatureExecutions { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<ContainerContextSettings> ContainerContextSettings { get; set; }
        public virtual ICollection<DataDomains> DataDomains { get; set; }
        public virtual ICollection<FeatureAlgorithmMembers> FeatureAlgorithmMembersFkFeatureCalculatedFeatureNavigation { get; set; }
        public virtual ICollection<FeatureAlgorithmMembers> FeatureAlgorithmMembersFkFeatureSourceFeatureNavigation { get; set; }
        public virtual ICollection<FeatureGroupMembers> FeatureGroupMembersFkFeatureGroupNavigation { get; set; }
        public virtual ICollection<FeatureGroupMembers> FeatureGroupMembersFkFeatureMemberNavigation { get; set; }
        public virtual ICollection<FeatureLinkPropertyValues> FeatureLinkPropertyValues { get; set; }
        public virtual ICollection<FeatureLinks> FeatureLinksFkFeatureDestinationNavigation { get; set; }
        public virtual ICollection<FeatureLinks> FeatureLinksFkFeatureNavigation { get; set; }
        public virtual ICollection<FeatureNetworkMembers> FeatureNetworkMembersFkFeatureMemberNavigation { get; set; }
        public virtual ICollection<FeatureNetworkMembers> FeatureNetworkMembersFkFeatureNetworkNavigation { get; set; }
        public virtual ICollection<FeatureSetMembers> FeatureSetMembers { get; set; }
        public virtual ICollection<Features> InverseFkFeatureCalculationFeatureDataSourceNavigation { get; set; }
        public virtual ICollection<Features> InverseFkFeatureContainerNavigation { get; set; }
        public virtual ICollection<Features> InverseFkFeatureInstantiatedFromNavigation { get; set; }
        public virtual ICollection<ObservationPlanViolations> ObservationPlanViolations { get; set; }
        public virtual ICollection<Observations> Observations { get; set; }
        public virtual ICollection<Privileges> Privileges { get; set; }
        public virtual ICollection<PropertyStructureConfigurationContexts> PropertyStructureConfigurationContexts { get; set; }
        public virtual ICollection<PropertyStructureInstances> PropertyStructureInstancesFkFeatureFlatNavigation { get; set; }
        public virtual ICollection<TaxonomyTermAssignments> TaxonomyTermAssignments { get; set; }
        public virtual ICollection<Urls> Urls { get; set; }
    }
}

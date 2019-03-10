using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class DataDomains
    {
        public DataDomains()
        {
            AliasSchemes = new HashSet<AliasSchemes>();
            ApprovalTemplates = new HashSet<ApprovalTemplates>();
            AssignedCoordinateSystems = new HashSet<AssignedCoordinateSystems>();
            AttachementTagAliases = new HashSet<AttachementTagAliases>();
            Axes = new HashSet<Axes>();
            Classifications = new HashSet<Classifications>();
            CrossSectionOutlines = new HashSet<CrossSectionOutlines>();
            DatadomainClassificationSpecifications = new HashSet<DatadomainClassificationSpecifications>();
            FeatureCreationTemplates = new HashSet<FeatureCreationTemplates>();
            FeatureSubtypes = new HashSet<FeatureSubtypes>();
            FeatureTags = new HashSet<FeatureTags>();
            Features = new HashSet<Features>();
            HiddenClassificationElements = new HashSet<HiddenClassificationElements>();
            HiddenFeatureTypes = new HashSet<HiddenFeatureTypes>();
            InverseFkDataDomainNavigation = new HashSet<DataDomains>();
            MapFileSets = new HashSet<MapFileSets>();
            ObservationNumberingDefinitions = new HashSet<ObservationNumberingDefinitions>();
            ObservationTags = new HashSet<ObservationTags>();
            Patterns = new HashSet<Patterns>();
            PresentationTemplates = new HashSet<PresentationTemplates>();
            Privileges = new HashSet<Privileges>();
            PropertyStructureConfigurationContexts = new HashSet<PropertyStructureConfigurationContexts>();
            Sensors = new HashSet<Sensors>();
            StoredExportDefinitions = new HashSet<StoredExportDefinitions>();
            StoredImportDefinitions = new HashSet<StoredImportDefinitions>();
            TaxonomyTerms = new HashSet<TaxonomyTerms>();
            Users = new HashSet<Users>();
            ViewDataDomainAssociations = new HashSet<ViewDataDomainAssociations>();
        }

        public int PkDataDomain { get; set; }
        public int? FkDataDomain { get; set; }
        public bool IsIdDomain { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short SequenceNumber { get; set; }
        public bool? ProjectedCoordinateSystemCanBeChanged { get; set; }
        public int? FkAxisReferenceSystemDefault { get; set; }
        public bool? GeodeticCoordinateSystemCanBeChanged { get; set; }
        public bool? AxisReferenceSystemCanBeChanged { get; set; }
        public bool? LocalCoordinateSystemCanBeChanged { get; set; }
        public int? FkFeatureDataDomainDetails { get; set; }

        public virtual AxisReferenceSystems FkAxisReferenceSystemDefaultNavigation { get; set; }
        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual Features FkFeatureDataDomainDetailsNavigation { get; set; }
        public virtual ICollection<AliasSchemes> AliasSchemes { get; set; }
        public virtual ICollection<ApprovalTemplates> ApprovalTemplates { get; set; }
        public virtual ICollection<AssignedCoordinateSystems> AssignedCoordinateSystems { get; set; }
        public virtual ICollection<AttachementTagAliases> AttachementTagAliases { get; set; }
        public virtual ICollection<Axes> Axes { get; set; }
        public virtual ICollection<Classifications> Classifications { get; set; }
        public virtual ICollection<CrossSectionOutlines> CrossSectionOutlines { get; set; }
        public virtual ICollection<DatadomainClassificationSpecifications> DatadomainClassificationSpecifications { get; set; }
        public virtual ICollection<FeatureCreationTemplates> FeatureCreationTemplates { get; set; }
        public virtual ICollection<FeatureSubtypes> FeatureSubtypes { get; set; }
        public virtual ICollection<FeatureTags> FeatureTags { get; set; }
        public virtual ICollection<Features> Features { get; set; }
        public virtual ICollection<HiddenClassificationElements> HiddenClassificationElements { get; set; }
        public virtual ICollection<HiddenFeatureTypes> HiddenFeatureTypes { get; set; }
        public virtual ICollection<DataDomains> InverseFkDataDomainNavigation { get; set; }
        public virtual ICollection<MapFileSets> MapFileSets { get; set; }
        public virtual ICollection<ObservationNumberingDefinitions> ObservationNumberingDefinitions { get; set; }
        public virtual ICollection<ObservationTags> ObservationTags { get; set; }
        public virtual ICollection<Patterns> Patterns { get; set; }
        public virtual ICollection<PresentationTemplates> PresentationTemplates { get; set; }
        public virtual ICollection<Privileges> Privileges { get; set; }
        public virtual ICollection<PropertyStructureConfigurationContexts> PropertyStructureConfigurationContexts { get; set; }
        public virtual ICollection<Sensors> Sensors { get; set; }
        public virtual ICollection<StoredExportDefinitions> StoredExportDefinitions { get; set; }
        public virtual ICollection<StoredImportDefinitions> StoredImportDefinitions { get; set; }
        public virtual ICollection<TaxonomyTerms> TaxonomyTerms { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public virtual ICollection<ViewDataDomainAssociations> ViewDataDomainAssociations { get; set; }
    }
}

namespace Services.API.DataAccess
{
    using Microsoft.EntityFrameworkCore;
    using Services.API.DataAccess.Models;

    public partial class RedbexApplicationServerDatabaseInstancecadContext : DbContext
    {
        public RedbexApplicationServerDatabaseInstancecadContext()
        {
        }

        public RedbexApplicationServerDatabaseInstancecadContext(DbContextOptions<RedbexApplicationServerDatabaseInstancecadContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AliasNames> AliasNames { get; set; }
        public virtual DbSet<AliasSchemes> AliasSchemes { get; set; }
        public virtual DbSet<AllowedContainedFeatureTypes> AllowedContainedFeatureTypes { get; set; }
        public virtual DbSet<AllowedSensorTypes> AllowedSensorTypes { get; set; }
        public virtual DbSet<AppliedFeatureTags> AppliedFeatureTags { get; set; }
        public virtual DbSet<AppliedObservationTags> AppliedObservationTags { get; set; }
        public virtual DbSet<ApprovalTemplateAssignements> ApprovalTemplateAssignements { get; set; }
        public virtual DbSet<ApprovalTemplateObligations> ApprovalTemplateObligations { get; set; }
        public virtual DbSet<ApprovalTemplates> ApprovalTemplates { get; set; }
        public virtual DbSet<ApprovalTemplateStages> ApprovalTemplateStages { get; set; }
        public virtual DbSet<ApprovalWorkflowAssignements> ApprovalWorkflowAssignements { get; set; }
        public virtual DbSet<ApprovalWorkflowObligations> ApprovalWorkflowObligations { get; set; }
        public virtual DbSet<ApprovalWorkflows> ApprovalWorkflows { get; set; }
        public virtual DbSet<ApprovalWorkflowStages> ApprovalWorkflowStages { get; set; }
        public virtual DbSet<AssignedCoordinateSystems> AssignedCoordinateSystems { get; set; }
        public virtual DbSet<AssociatedClassificationTypes> AssociatedClassificationTypes { get; set; }
        public virtual DbSet<Attachements> Attachements { get; set; }
        public virtual DbSet<AttachementTagAliases> AttachementTagAliases { get; set; }
        public virtual DbSet<AuthenticationAttempts> AuthenticationAttempts { get; set; }
        public virtual DbSet<AvailableUnitParts> AvailableUnitParts { get; set; }
        public virtual DbSet<AvailableUnits> AvailableUnits { get; set; }
        public virtual DbSet<Axes> Axes { get; set; }
        public virtual DbSet<AxisOffsetSpatialData> AxisOffsetSpatialData { get; set; }
        public virtual DbSet<AxisReferenceSystems> AxisReferenceSystems { get; set; }
        public virtual DbSet<BinaryPropertyValues> BinaryPropertyValues { get; set; }
        public virtual DbSet<BooleanPropertyValues> BooleanPropertyValues { get; set; }
        public virtual DbSet<CalculatedFeatureExecutions> CalculatedFeatureExecutions { get; set; }
        public virtual DbSet<ChronologicalSensorConfigurations> ChronologicalSensorConfigurations { get; set; }
        public virtual DbSet<ClassificationElements> ClassificationElements { get; set; }
        public virtual DbSet<ClassificationPropertyValues> ClassificationPropertyValues { get; set; }
        public virtual DbSet<Classifications> Classifications { get; set; }
        public virtual DbSet<ClassificationTypes> ClassificationTypes { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<ContainerContextSettings> ContainerContextSettings { get; set; }
        public virtual DbSet<CoordinateSystems> CoordinateSystems { get; set; }
        public virtual DbSet<CrossSectionOutlineAssignements> CrossSectionOutlineAssignements { get; set; }
        public virtual DbSet<CrossSectionOutlines> CrossSectionOutlines { get; set; }
        public virtual DbSet<DashboardConfigurations> DashboardConfigurations { get; set; }
        public virtual DbSet<DatadomainClassificationSpecifications> DatadomainClassificationSpecifications { get; set; }
        public virtual DbSet<DataDomains> DataDomains { get; set; }
        public virtual DbSet<Dems> Dems { get; set; }
        public virtual DbSet<DemTiles> DemTiles { get; set; }
        public virtual DbSet<DerivedQuantityParts> DerivedQuantityParts { get; set; }
        public virtual DbSet<EventScheduleDiscreteExecutionDates> EventScheduleDiscreteExecutionDates { get; set; }
        public virtual DbSet<EventSchedulePauses> EventSchedulePauses { get; set; }
        public virtual DbSet<EventSchedules> EventSchedules { get; set; }
        public virtual DbSet<FeatureAlgorithmMembers> FeatureAlgorithmMembers { get; set; }
        public virtual DbSet<FeatureConfigurations> FeatureConfigurations { get; set; }
        public virtual DbSet<FeatureCreationTemplates> FeatureCreationTemplates { get; set; }
        public virtual DbSet<FeatureGroupMembers> FeatureGroupMembers { get; set; }
        public virtual DbSet<FeatureLinkPropertyValues> FeatureLinkPropertyValues { get; set; }
        public virtual DbSet<FeatureLinks> FeatureLinks { get; set; }
        public virtual DbSet<FeatureNetworkMembers> FeatureNetworkMembers { get; set; }
        public virtual DbSet<Features> Features { get; set; }
        public virtual DbSet<FeatureSetMembers> FeatureSetMembers { get; set; }
        public virtual DbSet<FeatureSets> FeatureSets { get; set; }
        public virtual DbSet<FeatureSubtypes> FeatureSubtypes { get; set; }
        public virtual DbSet<FeatureTags> FeatureTags { get; set; }
        public virtual DbSet<FeatureTypeApplicationConfigurations> FeatureTypeApplicationConfigurations { get; set; }
        public virtual DbSet<FeatureTypes> FeatureTypes { get; set; }
        public virtual DbSet<FileReferences> FileReferences { get; set; }
        public virtual DbSet<ForwardingMediaQuotas> ForwardingMediaQuotas { get; set; }
        public virtual DbSet<GeneralTextTemplates> GeneralTextTemplates { get; set; }
        public virtual DbSet<GeographicSpatialData> GeographicSpatialData { get; set; }
        public virtual DbSet<GeometricSpatialData> GeometricSpatialData { get; set; }
        public virtual DbSet<GeometryPropertyValues> GeometryPropertyValues { get; set; }
        public virtual DbSet<HiddenClassificationElements> HiddenClassificationElements { get; set; }
        public virtual DbSet<HiddenFeatureTypes> HiddenFeatureTypes { get; set; }
        public virtual DbSet<HorizontalGeographicCoordinateSystems> HorizontalGeographicCoordinateSystems { get; set; }
        public virtual DbSet<Iconfiles> Iconfiles { get; set; }
        public virtual DbSet<Icons> Icons { get; set; }
        public virtual DbSet<ImportedFiles> ImportedFiles { get; set; }
        public virtual DbSet<ImportSessions> ImportSessions { get; set; }
        public virtual DbSet<MapFileSets> MapFileSets { get; set; }
        public virtual DbSet<MappingTemplateGeometries> MappingTemplateGeometries { get; set; }
        public virtual DbSet<MappingTemplateParts> MappingTemplateParts { get; set; }
        public virtual DbSet<MessageAttachements> MessageAttachements { get; set; }
        public virtual DbSet<MessageExternalRecipients> MessageExternalRecipients { get; set; }
        public virtual DbSet<MessageFolders> MessageFolders { get; set; }
        public virtual DbSet<MessageForwardingLogs> MessageForwardingLogs { get; set; }
        public virtual DbSet<MessageForwardingRules> MessageForwardingRules { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<MessageUserAssignements> MessageUserAssignements { get; set; }
        public virtual DbSet<MlTexts> MlTexts { get; set; }
        public virtual DbSet<MlTextTranslations> MlTextTranslations { get; set; }
        public virtual DbSet<MultiselectClassificationPropertyValues> MultiselectClassificationPropertyValues { get; set; }
        public virtual DbSet<MultiselectClassificationPropertyValueSelections> MultiselectClassificationPropertyValueSelections { get; set; }
        public virtual DbSet<NotificationForwardingRules> NotificationForwardingRules { get; set; }
        public virtual DbSet<NumericPropertyValues> NumericPropertyValues { get; set; }
        public virtual DbSet<ObservationAlarmAcknowledgingObligations> ObservationAlarmAcknowledgingObligations { get; set; }
        public virtual DbSet<ObservationAlarms> ObservationAlarms { get; set; }
        public virtual DbSet<ObservationNumberingDefinitions> ObservationNumberingDefinitions { get; set; }
        public virtual DbSet<ObservationPlans> ObservationPlans { get; set; }
        public virtual DbSet<ObservationPlanViolations> ObservationPlanViolations { get; set; }
        public virtual DbSet<Observations> Observations { get; set; }
        public virtual DbSet<ObservationSpyingDefinitions> ObservationSpyingDefinitions { get; set; }
        public virtual DbSet<ObservationTags> ObservationTags { get; set; }
        public virtual DbSet<OutputFiles> OutputFiles { get; set; }
        public virtual DbSet<Patterns> Patterns { get; set; }
        public virtual DbSet<PresentationTemplateBindings> PresentationTemplateBindings { get; set; }
        public virtual DbSet<PresentationTemplates> PresentationTemplates { get; set; }
        public virtual DbSet<Privileges> Privileges { get; set; }
        public virtual DbSet<Properties> Properties { get; set; }
        public virtual DbSet<PropertyCollectionConfigurations> PropertyCollectionConfigurations { get; set; }
        public virtual DbSet<PropertyCollectionMemberInstances> PropertyCollectionMemberInstances { get; set; }
        public virtual DbSet<PropertyCollections> PropertyCollections { get; set; }
        public virtual DbSet<PropertyConfigurations> PropertyConfigurations { get; set; }
        public virtual DbSet<PropertyStructureConfigurationContexts> PropertyStructureConfigurationContexts { get; set; }
        public virtual DbSet<PropertyStructureConfigurations> PropertyStructureConfigurations { get; set; }
        public virtual DbSet<PropertyStructureInstances> PropertyStructureInstances { get; set; }
        public virtual DbSet<PropertyStructures> PropertyStructures { get; set; }
        public virtual DbSet<QuantityPropertyValues> QuantityPropertyValues { get; set; }
        public virtual DbSet<QuantityTypes> QuantityTypes { get; set; }
        public virtual DbSet<QueuedJobs> QueuedJobs { get; set; }
        public virtual DbSet<ReferencedImagePropertyValues> ReferencedImagePropertyValues { get; set; }
        public virtual DbSet<Sensors> Sensors { get; set; }
        public virtual DbSet<SensorTypes> SensorTypes { get; set; }
        public virtual DbSet<SingletonSettings> SingletonSettings { get; set; }
        public virtual DbSet<SmartMessageFolders> SmartMessageFolders { get; set; }
        public virtual DbSet<StaticTimespans> StaticTimespans { get; set; }
        public virtual DbSet<StoredExportDefinitions> StoredExportDefinitions { get; set; }
        public virtual DbSet<StoredImportDefinitions> StoredImportDefinitions { get; set; }
        public virtual DbSet<StoredJobDefinitions> StoredJobDefinitions { get; set; }
        public virtual DbSet<StoredValidationConfigurations> StoredValidationConfigurations { get; set; }
        public virtual DbSet<StringPropertyValues> StringPropertyValues { get; set; }
        public virtual DbSet<Taxonomies> Taxonomies { get; set; }
        public virtual DbSet<TaxonomyTermAssignments> TaxonomyTermAssignments { get; set; }
        public virtual DbSet<TaxonomyTerms> TaxonomyTerms { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<UnitSystemConversionSettings> UnitSystemConversionSettings { get; set; }
        public virtual DbSet<Urls> Urls { get; set; }
        public virtual DbSet<UsedClassificationTypes> UsedClassificationTypes { get; set; }
        public virtual DbSet<UserFavorites> UserFavorites { get; set; }
        public virtual DbSet<UserGroupMemberships> UserGroupMemberships { get; set; }
        public virtual DbSet<UserGroups> UserGroups { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserSessions> UserSessions { get; set; }
        public virtual DbSet<ValidationResults> ValidationResults { get; set; }
        public virtual DbSet<ValidationRuns> ValidationRuns { get; set; }
        public virtual DbSet<VerticalCoordinateSystems> VerticalCoordinateSystems { get; set; }
        public virtual DbSet<ViewDataDomainAssociations> ViewDataDomainAssociations { get; set; }
        public virtual DbSet<Views> Views { get; set; }
        public virtual DbSet<ViewUserSettings> ViewUserSettings { get; set; }
        public virtual DbSet<Widgets> Widgets { get; set; }
        public virtual DbSet<WorkspaceAssociations> WorkspaceAssociations { get; set; }
        public virtual DbSet<Workspaces> Workspaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;Database=Redbex Application Server Database - Instancecad;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-preview3-35497");

            modelBuilder.Entity<AliasNames>(entity =>
            {
                entity.HasKey(e => e.PkAliasName)
                    .HasName("AliasNames_Pk_IdTranslation")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkAliasScheme)
                    .HasName("AliasNames_Fk_AliasScheme");

                entity.HasIndex(e => e.FkFeature)
                    .HasName("AliasNames_Fk_Feature");

                entity.HasIndex(e => e.Name)
                    .HasName("AliasNames_AliasName");

                entity.HasIndex(e => new { e.FkAliasScheme, e.Name })
                    .HasName("AliasNames_UniqueNamingInScheme")
                    .IsUnique()
                    .HasFilter("([Name]<>'')");

                entity.HasIndex(e => new { e.FkFeature, e.FkAliasScheme })
                    .HasName("AliasNames_OneAliasPerScheme")
                    .IsUnique();

                entity.Property(e => e.PkAliasName).HasColumnName("Pk_AliasName");

                entity.Property(e => e.FkAliasScheme).HasColumnName("Fk_AliasScheme");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkAliasSchemeNavigation)
                    .WithMany(p => p.AliasNames)
                    .HasForeignKey(d => d.FkAliasScheme)
                    .HasConstraintName("AliasSchemes_AliasNames");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.AliasNames)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Features_IdTranslations");
            });

            modelBuilder.Entity<AliasSchemes>(entity =>
            {
                entity.HasKey(e => e.PkAliasScheme)
                    .HasName("AliasSchemes_Pk_AliasScheme")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkAliasScheme).HasColumnName("Pk_AliasScheme");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.AliasSchemes)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_AliasSchemes");
            });

            modelBuilder.Entity<AllowedContainedFeatureTypes>(entity =>
            {
                entity.HasKey(e => e.PkAllowedContainedFeatureType)
                    .HasName("AllowedContainedFeatureTypes_Pk_AllowedContainedFeatureType")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeatureTypeContainer)
                    .HasName("AllowedContainedFeatureTypes_Fk_FeatureType_Container");

                entity.Property(e => e.PkAllowedContainedFeatureType).HasColumnName("Pk_AllowedContainedFeatureType");

                entity.Property(e => e.ContainedFeatureTypeGuid).HasColumnName("ContainedFeatureTypeGUID");

                entity.Property(e => e.FkFeatureTypeContainer).HasColumnName("Fk_FeatureType_Container");

                entity.HasOne(d => d.FkFeatureTypeContainerNavigation)
                    .WithMany(p => p.AllowedContainedFeatureTypes)
                    .HasForeignKey(d => d.FkFeatureTypeContainer)
                    .HasConstraintName("FeatureTypes_AllowedContainedFeatureTypes_Container");
            });

            modelBuilder.Entity<AllowedSensorTypes>(entity =>
            {
                entity.HasKey(e => e.PkAllowedSensorType)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeatureType)
                    .HasName("AllowedSensorTypes_Fk_FeatureType");

                entity.Property(e => e.PkAllowedSensorType).HasColumnName("Pk_AllowedSensorType");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.AllowedSensorTypes)
                    .HasForeignKey(d => d.FkFeatureType)
                    .HasConstraintName("FeatureTypes_AllowedSensorTypes");
            });

            modelBuilder.Entity<AppliedFeatureTags>(entity =>
            {
                entity.HasKey(e => e.PkAppliedFeatureTag)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeature)
                    .HasName("AppliedFeatureTags_Fk_Feature");

                entity.HasIndex(e => e.FkFeatureTag)
                    .HasName("AppliedFeatureTags_Fk_FeatureTag");

                entity.HasIndex(e => new { e.FkFeatureTag, e.FkFeature })
                    .HasName("AppliedFeatureTags_Combined")
                    .IsUnique();

                entity.Property(e => e.PkAppliedFeatureTag).HasColumnName("Pk_AppliedFeatureTag");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkFeatureTag).HasColumnName("Fk_FeatureTag");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.AppliedFeatureTags)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Features_AppliedFeatureTags");

                entity.HasOne(d => d.FkFeatureTagNavigation)
                    .WithMany(p => p.AppliedFeatureTags)
                    .HasForeignKey(d => d.FkFeatureTag)
                    .HasConstraintName("FeatureTags_AppliedFeatureTags");
            });

            modelBuilder.Entity<AppliedObservationTags>(entity =>
            {
                entity.HasKey(e => e.PkAppliedObservationTags)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkObservation)
                    .HasName("AppliedObservationTags_Fk_Observation");

                entity.HasIndex(e => e.FkObservationTag)
                    .HasName("AppliedObservationTags_Fk_ObservationTag");

                entity.HasIndex(e => new { e.FkObservationTag, e.FkObservation })
                    .HasName("AppliedObservationTags_Combined")
                    .IsUnique();

                entity.Property(e => e.PkAppliedObservationTags).HasColumnName("Pk_AppliedObservationTags");

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.Property(e => e.FkObservationTag).HasColumnName("Fk_ObservationTag");

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithMany(p => p.AppliedObservationTags)
                    .HasForeignKey(d => d.FkObservation)
                    .HasConstraintName("Observations_AppliedObservationTags");

                entity.HasOne(d => d.FkObservationTagNavigation)
                    .WithMany(p => p.AppliedObservationTags)
                    .HasForeignKey(d => d.FkObservationTag)
                    .HasConstraintName("ObservationTags_AppliedObservationTags");
            });

            modelBuilder.Entity<ApprovalTemplateAssignements>(entity =>
            {
                entity.HasKey(e => e.PkApprovalTemplateAssignement)
                    .HasName("ApprovalTemplateAssignements_PK_ApprovalTemplateAssignement")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkContainerContextSetting)
                    .HasName("ApprovalTemplateAssignements_Fk_ContainerContextSetting");

                entity.Property(e => e.PkApprovalTemplateAssignement).HasColumnName("Pk_ApprovalTemplateAssignement");

                entity.Property(e => e.FkApprovalTemplateFeature).HasColumnName("Fk_ApprovalTemplate_Feature");

                entity.Property(e => e.FkApprovalTemplateObservation).HasColumnName("Fk_ApprovalTemplate_Observation");

                entity.Property(e => e.FkContainerContextSetting).HasColumnName("Fk_ContainerContextSetting");

                entity.HasOne(d => d.FkApprovalTemplateFeatureNavigation)
                    .WithMany(p => p.ApprovalTemplateAssignementsFkApprovalTemplateFeatureNavigation)
                    .HasForeignKey(d => d.FkApprovalTemplateFeature)
                    .HasConstraintName("ApprovalTemplates_ApprovalTemplateAssignments_Feature");

                entity.HasOne(d => d.FkApprovalTemplateObservationNavigation)
                    .WithMany(p => p.ApprovalTemplateAssignementsFkApprovalTemplateObservationNavigation)
                    .HasForeignKey(d => d.FkApprovalTemplateObservation)
                    .HasConstraintName("ApprovalTemplates_ApprovalTemplateAssignments_Observation");

                entity.HasOne(d => d.FkContainerContextSettingNavigation)
                    .WithMany(p => p.ApprovalTemplateAssignements)
                    .HasForeignKey(d => d.FkContainerContextSetting)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ContainerContextSettings_ApprovalTemplateAssignements");
            });

            modelBuilder.Entity<ApprovalTemplateObligations>(entity =>
            {
                entity.HasKey(e => e.PkApprovalObligation)
                    .HasName("ApprovalObligations_Pk_ApprovalObligation")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkApprovalObligation).HasColumnName("Pk_ApprovalObligation");

                entity.Property(e => e.FkApprovalStage).HasColumnName("Fk_ApprovalStage");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.FkUserGroup).HasColumnName("Fk_UserGroup");

                entity.HasOne(d => d.FkApprovalStageNavigation)
                    .WithMany(p => p.ApprovalTemplateObligations)
                    .HasForeignKey(d => d.FkApprovalStage)
                    .HasConstraintName("ApprovalTemplateStages_ApprovalTemplateObligations");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.ApprovalTemplateObligations)
                    .HasForeignKey(d => d.FkUser)
                    .HasConstraintName("Users_ApprovalTemplateObligations");

                entity.HasOne(d => d.FkUserGroupNavigation)
                    .WithMany(p => p.ApprovalTemplateObligations)
                    .HasForeignKey(d => d.FkUserGroup)
                    .HasConstraintName("UserGroups_ApprovalTemplateObligations");
            });

            modelBuilder.Entity<ApprovalTemplates>(entity =>
            {
                entity.HasKey(e => e.PkApprovalTemplate)
                    .HasName("ApprovalTemplate_Pk_ApprovalTemplate")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkApprovalTemplate).HasColumnName("Pk_ApprovalTemplate");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.ApprovalTemplates)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_ApprovalTemplates");
            });

            modelBuilder.Entity<ApprovalTemplateStages>(entity =>
            {
                entity.HasKey(e => e.PkApprovalTemplateStage)
                    .HasName("ApprovalTemplateStages_Pk_ApprovalTemplateStage")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkApprovalTemplateStage).HasColumnName("Pk_ApprovalTemplateStage");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkApprovalTemplate).HasColumnName("Fk_ApprovalTemplate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkApprovalTemplateNavigation)
                    .WithMany(p => p.ApprovalTemplateStages)
                    .HasForeignKey(d => d.FkApprovalTemplate)
                    .HasConstraintName("ApprovalTemplates_ApprovalTemplateStages");
            });

            modelBuilder.Entity<ApprovalWorkflowAssignements>(entity =>
            {
                entity.HasKey(e => e.PkApprovalWorkflowAssignement)
                    .HasName("ApprovalWorkflowAssignements_Pk_ApprovalWorkflowAssignements")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.FkApprovalWorkflow, e.FkObservation })
                    .HasName("ApprovalWorkflowAssignements_UniqueAssignement")
                    .IsUnique();

                entity.Property(e => e.PkApprovalWorkflowAssignement).HasColumnName("Pk_ApprovalWorkflowAssignement");

                entity.Property(e => e.FkApprovalWorkflow).HasColumnName("Fk_ApprovalWorkflow");

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.HasOne(d => d.FkApprovalWorkflowNavigation)
                    .WithMany(p => p.ApprovalWorkflowAssignements)
                    .HasForeignKey(d => d.FkApprovalWorkflow)
                    .HasConstraintName("ApprovalWorkflows_ApprovalWorkflowAssignements");

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithMany(p => p.ApprovalWorkflowAssignements)
                    .HasForeignKey(d => d.FkObservation)
                    .HasConstraintName("Observations_ApprovalWorkflowAssignements");
            });

            modelBuilder.Entity<ApprovalWorkflowObligations>(entity =>
            {
                entity.HasKey(e => e.PkApprovalWorkflowObligation)
                    .HasName("ApprovalWorkflowObligations_Pk_ApprovalWorkflowObligation")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkApprovalWorkflowStage)
                    .HasName("ApprovalWorkflowObligations_Fk_ApprovalWorkflowStage");

                entity.HasIndex(e => e.FkUser)
                    .HasName("ApprovalWorkflowObligations_Fk_User");

                entity.Property(e => e.PkApprovalWorkflowObligation).HasColumnName("Pk_ApprovalWorkflowObligation");

                entity.Property(e => e.ApprovalNotes).HasMaxLength(4000);

                entity.Property(e => e.ApprovalTimestamp).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.FkApprovalWorkflowStage).HasColumnName("Fk_ApprovalWorkflowStage");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.LastApprovalStatusChange)
                    .HasColumnType("datetimeoffset(2)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LastUpdate).HasColumnType("datetimeoffset(2)");

                entity.HasOne(d => d.FkApprovalWorkflowStageNavigation)
                    .WithMany(p => p.ApprovalWorkflowObligations)
                    .HasForeignKey(d => d.FkApprovalWorkflowStage)
                    .HasConstraintName("ApprovalWorkflowStages_ApprovalWorkflowObligations");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.ApprovalWorkflowObligations)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_ApprovalWorkflowObligations");
            });

            modelBuilder.Entity<ApprovalWorkflows>(entity =>
            {
                entity.HasKey(e => e.PkApprovalWorkflow)
                    .HasName("ApprovalWorkflow_Pk_ApprovalWorkflow")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ApprovalStatus)
                    .HasName("ApprovalWorkflow_ApprovalStatus");

                entity.HasIndex(e => e.FkFeature)
                    .HasName("ApprovalWorkflow_FK_Feature");

                entity.HasIndex(e => e.FkFeatureObservation)
                    .HasName("ApprovalWorkflow_FK_Featue_Observation");

                entity.HasIndex(e => e.Start)
                    .HasName("ApprovalWorkflow_Start");

                entity.Property(e => e.PkApprovalWorkflow).HasColumnName("Pk_ApprovalWorkflow");

                entity.Property(e => e.ApprovedButErroneousComment).HasMaxLength(4000);

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkFeatureObservation).HasColumnName("Fk_Feature_Observation");

                entity.Property(e => e.FkUserSetErroneous).HasColumnName("Fk_User_SetErroneous");

                entity.Property(e => e.FkUserSetObsolete).HasColumnName("Fk_User_SetObsolete");

                entity.Property(e => e.LastApprovalStatusChange).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ObsoleteComment).HasMaxLength(4000);

                entity.Property(e => e.Start).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.ApprovalWorkflowsFkFeatureNavigation)
                    .HasForeignKey(d => d.FkFeature)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Features_ApprovalWorkflows");

                entity.HasOne(d => d.FkFeatureObservationNavigation)
                    .WithMany(p => p.ApprovalWorkflowsFkFeatureObservationNavigation)
                    .HasForeignKey(d => d.FkFeatureObservation)
                    .HasConstraintName("Features_ApprovalWorkflows_Observation");

                entity.HasOne(d => d.FkUserSetErroneousNavigation)
                    .WithMany(p => p.ApprovalWorkflowsFkUserSetErroneousNavigation)
                    .HasForeignKey(d => d.FkUserSetErroneous)
                    .HasConstraintName("Users_ApprovalWorkflows_SetErroneous");

                entity.HasOne(d => d.FkUserSetObsoleteNavigation)
                    .WithMany(p => p.ApprovalWorkflowsFkUserSetObsoleteNavigation)
                    .HasForeignKey(d => d.FkUserSetObsolete)
                    .HasConstraintName("Users_ApprovalWorkflows_SetObsolete");
            });

            modelBuilder.Entity<ApprovalWorkflowStages>(entity =>
            {
                entity.HasKey(e => e.PkApprovalWorkflowStage)
                    .HasName("ApprovalWorkflowStages_Pk_ApprovalWorkflowStage")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkApprovalWorkflow)
                    .HasName("ApprovalWorkflowStages_Fk_ApprovalWorkflow");

                entity.HasIndex(e => e.StageSequenceNo)
                    .HasName("ApprovalWorkflowStages_StageSequenceNo");

                entity.Property(e => e.PkApprovalWorkflowStage).HasColumnName("Pk_ApprovalWorkflowStage");

                entity.Property(e => e.FkApprovalWorkflow).HasColumnName("Fk_ApprovalWorkflow");

                entity.HasOne(d => d.FkApprovalWorkflowNavigation)
                    .WithMany(p => p.ApprovalWorkflowStages)
                    .HasForeignKey(d => d.FkApprovalWorkflow)
                    .HasConstraintName("ApprovalWorkflows_ApprovalWorkflowStages");
            });

            modelBuilder.Entity<AssignedCoordinateSystems>(entity =>
            {
                entity.HasKey(e => e.PkAssignedCoordinateSystems)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkAssignedCoordinateSystems).HasColumnName("Pk_AssignedCoordinateSystems");

                entity.Property(e => e.FkCoordinateSystem).HasColumnName("Fk_CoordinateSystem");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.HasOne(d => d.FkCoordinateSystemNavigation)
                    .WithMany(p => p.AssignedCoordinateSystems)
                    .HasForeignKey(d => d.FkCoordinateSystem)
                    .HasConstraintName("CoordinateSystems_AssignedCoordinateSystems");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.AssignedCoordinateSystems)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_AssignedCoordinateSystems");
            });

            modelBuilder.Entity<AssociatedClassificationTypes>(entity =>
            {
                entity.HasKey(e => e.PkAssociatedClassificationType)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkAssociatedClassificationType).HasColumnName("Pk_AssociatedClassificationType");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.AssociatedClassificationTypes)
                    .HasForeignKey(d => d.FkFeatureType)
                    .HasConstraintName("FeatureTypes_AssociatedClassificationTypes");
            });

            modelBuilder.Entity<Attachements>(entity =>
            {
                entity.HasKey(e => e.PkAttachement)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeature)
                    .HasName("Attachements_FK_Feature");

                entity.HasIndex(e => e.FkObservation)
                    .HasName("Attachements_FK_Observation");

                entity.HasIndex(e => e.PropertyStructureInstanceGuid)
                    .HasName("Attachments_PropertyStructureInstanceGuid");

                entity.HasIndex(e => e.SequenceNumber)
                    .HasName("Attachements_SequenceNumber");

                entity.Property(e => e.PkAttachement).HasColumnName("Pk_Attachement");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.SequenceNumber).HasDefaultValueSql("((1000))");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.Attachements)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Features_Attachements");

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithMany(p => p.Attachements)
                    .HasForeignKey(d => d.FkObservation)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Observations_Attachements");
            });

            modelBuilder.Entity<AttachementTagAliases>(entity =>
            {
                entity.HasKey(e => e.PkAttachementTagAlias)
                    .HasName("AttachementTagAliases_Pk_AttachementTagAliases")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.FkDataDomain, e.FkFeatureType, e.TagNo })
                    .HasName("AttachementTagAliases_Combined")
                    .IsUnique();

                entity.Property(e => e.PkAttachementTagAlias).HasColumnName("Pk_AttachementTagAlias");

                entity.Property(e => e.AliasName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.AttachementTagAliases)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_AttachementTagAliases");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.AttachementTagAliases)
                    .HasForeignKey(d => d.FkFeatureType)
                    .HasConstraintName("FeatureTypes_AttachementTagAliases");
            });

            modelBuilder.Entity<AuthenticationAttempts>(entity =>
            {
                entity.HasKey(e => e.PkAuthenticationAttempt)
                    .HasName("AuthenticationAttempts_Pk_AuthenticationAttempt")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.UsedUserName)
                    .HasName("AuthenticationAttempts_UsedUserName");

                entity.Property(e => e.PkAuthenticationAttempt).HasColumnName("Pk_AuthenticationAttempt");

                entity.Property(e => e.AuthenticationTimestamp).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.UsedUserName).HasMaxLength(100);
            });

            modelBuilder.Entity<AvailableUnitParts>(entity =>
            {
                entity.HasKey(e => e.PkAvailabileUnitPart)
                    .HasName("AvailableUnitParts_Pk_AvailableUnitPart")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkAvailabileUnitPart).HasColumnName("Pk_AvailabileUnitPart");

                entity.Property(e => e.FkAvailableUnit).HasColumnName("Fk_AvailableUnit");

                entity.Property(e => e.FkDerivedQuantityPart).HasColumnName("Fk_DerivedQuantityPart");

                entity.Property(e => e.FkUnit).HasColumnName("Fk_Unit");

                entity.HasOne(d => d.FkAvailableUnitNavigation)
                    .WithMany(p => p.AvailableUnitParts)
                    .HasForeignKey(d => d.FkAvailableUnit)
                    .HasConstraintName("AvailableUnits_AvailableUnitParts");

                entity.HasOne(d => d.FkDerivedQuantityPartNavigation)
                    .WithMany(p => p.AvailableUnitParts)
                    .HasForeignKey(d => d.FkDerivedQuantityPart)
                    .HasConstraintName("DerivedQuantityParts_Fk_AvailableUnitParts");

                entity.HasOne(d => d.FkUnitNavigation)
                    .WithMany(p => p.AvailableUnitParts)
                    .HasForeignKey(d => d.FkUnit)
                    .HasConstraintName("Units_AvailableUnitParts");
            });

            modelBuilder.Entity<AvailableUnits>(entity =>
            {
                entity.HasKey(e => e.PkAvailableUnit)
                    .HasName("AvailableUnits_Pk_AvailableUnit")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.AvailableUnitGuid)
                    .HasName("AvailableUnits_AvailableTypeGuid")
                    .IsUnique();

                entity.Property(e => e.PkAvailableUnit).HasColumnName("Pk_AvailableUnit");

                entity.Property(e => e.AvailableUnitGuid).HasColumnName("AvailableUnitGUID");

                entity.Property(e => e.FkQuantityType).HasColumnName("Fk_QuantityType");

                entity.Property(e => e.IdentifyingName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntName).HasMaxLength(200);

                entity.Property(e => e.NameGuid).HasColumnName("NameGUID");

                entity.Property(e => e.PrefixMultiplicant).HasDefaultValueSql("((1))");

                entity.Property(e => e.SymbolGuid).HasColumnName("SymbolGUID");

                entity.HasOne(d => d.FkQuantityTypeNavigation)
                    .WithMany(p => p.AvailableUnits)
                    .HasForeignKey(d => d.FkQuantityType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QuantityTypes_AvailableUnits");
            });

            modelBuilder.Entity<Axes>(entity =>
            {
                entity.HasKey(e => e.PkAxis)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkAxis).HasColumnName("Pk_Axis");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.DouglasPeuckerSimplificationTolerance).HasDefaultValueSql("((-1))");

                entity.Property(e => e.FkCoordinateSystem).HasColumnName("Fk_CoordinateSystem");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.HasOne(d => d.FkCoordinateSystemNavigation)
                    .WithMany(p => p.Axes)
                    .HasForeignKey(d => d.FkCoordinateSystem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CoordinateSystems_Axes");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.Axes)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_Axes");
            });

            modelBuilder.Entity<AxisOffsetSpatialData>(entity =>
            {
                entity.HasKey(e => e.PkAxisOffsetSpatialDatum)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeature)
                    .HasName("AxisOffsetSpatialData_Fk_Feature")
                    .IsUnique()
                    .HasFilter("([Fk_Feature] IS NOT NULL)");

                entity.HasIndex(e => e.FkObservation)
                    .HasName("AxisOffsetSpatialData_Fk_Observation")
                    .IsUnique()
                    .HasFilter("([Fk_Observation] IS NOT NULL)");

                entity.HasIndex(e => e.Offset1)
                    .HasName("AxisOffsetSpatialData_Offset1");

                entity.Property(e => e.PkAxisOffsetSpatialDatum).HasColumnName("Pk_AxisOffsetSpatialDatum");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithOne(p => p.AxisOffsetSpatialData)
                    .HasForeignKey<AxisOffsetSpatialData>(d => d.FkFeature)
                    .HasConstraintName("Features_AxisOffsetSpatialData");

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithOne(p => p.AxisOffsetSpatialData)
                    .HasForeignKey<AxisOffsetSpatialData>(d => d.FkObservation)
                    .HasConstraintName("Observations_AxisOffsetSpatialData");
            });

            modelBuilder.Entity<AxisReferenceSystems>(entity =>
            {
                entity.HasKey(e => e.PkAxisReferenceSystem)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkAxisReferenceSystem).HasColumnName("Pk_AxisReferenceSystem");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkAxis).HasColumnName("Fk_Axis");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LcsConversionFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.LcsUnit)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MappingTemplateMaximumWidthLeft).HasDefaultValueSql("((30))");

                entity.Property(e => e.MappingTemplateMaximumWidthRight).HasDefaultValueSql("((30))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OffsetConversionFactor).HasDefaultValueSql("((1))");

                entity.Property(e => e.OffsetUnit)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.FkAxisNavigation)
                    .WithMany(p => p.AxisReferenceSystems)
                    .HasForeignKey(d => d.FkAxis)
                    .HasConstraintName("Axes_AxisReferenceSystems");
            });

            modelBuilder.Entity<BinaryPropertyValues>(entity =>
            {
                entity.HasKey(e => e.PkBinaryPropertyValue)
                    .HasName("BinaryPropertyValues_Pk_BinaryPropertyValue");

                entity.HasIndex(e => e.FkProperty)
                    .HasName("BooleanPropertyValues_Fk_Property");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("BooleanPropertyValues_Fk_PropertyStructureInstance");

                entity.Property(e => e.PkBinaryPropertyValue).HasColumnName("Pk_BinaryPropertyValue");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.BinaryPropertyValues)
                    .HasForeignKey(d => d.FkProperty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Properties_BinaryPropertyValues");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.BinaryPropertyValues)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyStructureInstances_BinaryPropertyValues");
            });

            modelBuilder.Entity<BooleanPropertyValues>(entity =>
            {
                entity.HasKey(e => e.PkBooleanPropertyValue)
                    .HasName("BooleanPropertyValues_Pk_BooleanPropertyValues");

                entity.HasIndex(e => e.FkProperty)
                    .HasName("BooleanPropertyValues_Fk_Property");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("BooleanPropertyValues_Fk_PropertyStructureInstance");

                entity.HasIndex(e => e.Value)
                    .HasName("BooleanPropertyValues_Value");

                entity.Property(e => e.PkBooleanPropertyValue).HasColumnName("Pk_BooleanPropertyValue");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.BooleanPropertyValues)
                    .HasForeignKey(d => d.FkProperty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Properties_BooleanPropertyValues");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.BooleanPropertyValues)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyStructureInstances_BooleanPropertyValues");
            });

            modelBuilder.Entity<CalculatedFeatureExecutions>(entity =>
            {
                entity.HasKey(e => e.PkCalculatedFeatureExecution)
                    .HasName("CalculatedFeatureExecutions_Pk_CalculatedFeatureExecution")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ExecutionStart)
                    .HasName("CalculatedFeatureExecutions_ExecutionStart");

                entity.HasIndex(e => e.FkFeature)
                    .HasName("CalculatedFeatureExecutions_Fk_Feature");

                entity.Property(e => e.PkCalculatedFeatureExecution).HasColumnName("Pk_CalculatedFeatureExecution");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkQueuedJob).HasColumnName("Fk_QueuedJob");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.CalculatedFeatureExecutions)
                    .HasForeignKey(d => d.FkFeature)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Features_CalculatedFeatureExecutions");

                entity.HasOne(d => d.FkQueuedJobNavigation)
                    .WithMany(p => p.CalculatedFeatureExecutions)
                    .HasForeignKey(d => d.FkQueuedJob)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QueuedJobs_CalculatedFeatureExecutions");
            });

            modelBuilder.Entity<ChronologicalSensorConfigurations>(entity =>
            {
                entity.HasKey(e => e.PkChronologicalSensorConfiguration)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkChronologicalSensorConfiguration).HasColumnName("Pk_ChronologicalSensorConfiguration");

                entity.Property(e => e.FkSensor).HasColumnName("Fk_Sensor");

                entity.HasOne(d => d.FkSensorNavigation)
                    .WithMany(p => p.ChronologicalSensorConfigurations)
                    .HasForeignKey(d => d.FkSensor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Sensors_ChronologicalSensorConfigurations");
            });

            modelBuilder.Entity<ClassificationElements>(entity =>
            {
                entity.HasKey(e => e.PkClassificationElement)
                    .HasName("ClassificationElements_Pk_ClassificationElement")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.Code)
                    .HasName("ClassificationElements_Code")
                    .HasFilter("([Code] IS NOT NULL AND [Code]<>'')");

                entity.HasIndex(e => e.FkClassification)
                    .HasName("ClassificationElements_Fk_Classification");

                entity.HasIndex(e => e.Name)
                    .HasName("ClassificationElements_Name");

                entity.HasIndex(e => e.SequenceNumber)
                    .HasName("ClassificationElements_Sequencenumber");

                entity.HasIndex(e => new { e.FkClassification, e.Code })
                    .HasName("ClassificationElements_UniqueCodeWithinClassification")
                    .IsUnique()
                    .HasFilter("([Code] IS NOT NULL AND [Code]<>'')");

                entity.HasIndex(e => new { e.FkClassification, e.Name })
                    .HasName("ClassificationElements_UniqueNameWithinClassification")
                    .IsUnique();

                entity.Property(e => e.PkClassificationElement).HasColumnName("Pk_ClassificationElement");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkClassification).HasColumnName("Fk_Classification");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkClassificationNavigation)
                    .WithMany(p => p.ClassificationElements)
                    .HasForeignKey(d => d.FkClassification)
                    .HasConstraintName("Classifications_Classificationelements");
            });

            modelBuilder.Entity<ClassificationPropertyValues>(entity =>
            {
                entity.HasKey(e => e.PkClassificationPropertyValue)
                    .HasName("ClassificationPropertyvalues_Pk_ClassificationPropertyvalue");

                entity.HasIndex(e => e.FkClassificationElement)
                    .HasName("ClassificationPropertyValues_Fk_ClassificationElement");

                entity.HasIndex(e => e.FkProperty)
                    .HasName("ClassificationPropertyValues_Fk_Property");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("ClassificationPropertyValues_Fk_PropertyStructureInstance");

                entity.Property(e => e.PkClassificationPropertyValue).HasColumnName("Pk_ClassificationPropertyValue");

                entity.Property(e => e.FkClassificationElement).HasColumnName("Fk_ClassificationElement");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.HasOne(d => d.FkClassificationElementNavigation)
                    .WithMany(p => p.ClassificationPropertyValues)
                    .HasForeignKey(d => d.FkClassificationElement)
                    .HasConstraintName("ClassificationElements_ClassificationPropertyvalues");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.ClassificationPropertyValues)
                    .HasForeignKey(d => d.FkProperty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Properties_ClassificationPropertyValues");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.ClassificationPropertyValues)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyStructureInstances_ClassificationPropertyvalues");
            });

            modelBuilder.Entity<Classifications>(entity =>
            {
                entity.HasKey(e => e.PkClassification)
                    .HasName("Classifications_Pk_Classification")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkClassification).HasColumnName("Pk_Classification");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkClassificationType).HasColumnName("Fk_ClassificationType");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkClassificationTypeNavigation)
                    .WithMany(p => p.Classifications)
                    .HasForeignKey(d => d.FkClassificationType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClassificationTypes_Classifications");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.Classifications)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DataDomains_Classifications");
            });

            modelBuilder.Entity<ClassificationTypes>(entity =>
            {
                entity.HasKey(e => e.PkClassificationType)
                    .HasName("ClassificationTypes_Pk_ClassificationType")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ClassificationTypeGuid)
                    .HasName("ClassificationTypes_ClassificationTypeGuid")
                    .IsUnique();

                entity.Property(e => e.PkClassificationType).HasColumnName("Pk_ClassificationType");

                entity.Property(e => e.DescriptionGuid).HasColumnName("DescriptionGUID");

                entity.Property(e => e.NameGuid).HasColumnName("NameGUID");

                entity.Property(e => e.PathGuid).HasColumnName("PathGUID");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.PkComment)
                    .HasName("Comments_Pk_Comment")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.CreatedOn)
                    .HasName("Comments_CommentTimestamp");

                entity.HasIndex(e => e.FkFeature)
                    .HasName("Comments_Fk_Feature");

                entity.HasIndex(e => e.FkObservation)
                    .HasName("Comments_Fk_Observation");

                entity.HasIndex(e => e.PropertyStructureInstanceGuid)
                    .HasName("Comments_PropertyStructureInstanceGuid");

                entity.Property(e => e.PkComment).HasColumnName("Pk_Comment");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.OriginallyCommentedBy).HasMaxLength(200);

                entity.Property(e => e.RevocationReason).HasMaxLength(4000);

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Features_Comments");

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.FkObservation)
                    .HasConstraintName("Observations_Comments");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_Comments");
            });

            modelBuilder.Entity<ContainerContextSettings>(entity =>
            {
                entity.HasKey(e => e.PkContainerContextSetting)
                    .HasName("ContainerContextSetting_Pk_ContainerContextSetting")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeature)
                    .HasName("ContainerContextSetting_Fk_Feature");

                entity.HasIndex(e => e.FkFeatureSubtype)
                    .HasName("ContainerContextSetting_Fk_FeatureSubtype");

                entity.HasIndex(e => e.FkFeatureType)
                    .HasName("ContainerContextSetting_Fk_FeatureType");

                entity.Property(e => e.PkContainerContextSetting).HasColumnName("Pk_ContainerContextSetting");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkFeatureSubtype).HasColumnName("Fk_FeatureSubtype");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.Property(e => e.NameFilter).HasMaxLength(200);

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.ContainerContextSettings)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Features_ContainerContextSettings");

                entity.HasOne(d => d.FkFeatureSubtypeNavigation)
                    .WithMany(p => p.ContainerContextSettings)
                    .HasForeignKey(d => d.FkFeatureSubtype)
                    .HasConstraintName("FeatureSubType_ContainerContextSettings");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.ContainerContextSettings)
                    .HasForeignKey(d => d.FkFeatureType)
                    .HasConstraintName("FeatureTypes_ContainerContextSettings");
            });

            modelBuilder.Entity<CoordinateSystems>(entity =>
            {
                entity.HasKey(e => e.PkCoordinateSystem)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.EpsgCode)
                    .HasName("CoordinateSystems_EpsgCode");

                entity.Property(e => e.PkCoordinateSystem).HasColumnName("Pk_CoordinateSystem");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkHorizontalGeographicCoordinateSystem).HasColumnName("Fk_HorizontalGeographicCoordinateSystem");

                entity.Property(e => e.FkVerticalCoordinateSystem).HasColumnName("Fk_VerticalCoordinateSystem");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LinearUnitName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Proj4Definition).HasMaxLength(1000);

                entity.HasOne(d => d.FkHorizontalGeographicCoordinateSystemNavigation)
                    .WithMany(p => p.CoordinateSystems)
                    .HasForeignKey(d => d.FkHorizontalGeographicCoordinateSystem)
                    .HasConstraintName("HorizontalGeographicCoordinateSystems_CoordinateSystems");

                entity.HasOne(d => d.FkVerticalCoordinateSystemNavigation)
                    .WithMany(p => p.CoordinateSystems)
                    .HasForeignKey(d => d.FkVerticalCoordinateSystem)
                    .HasConstraintName("VerticalCoordinateSystems_CoordinateSystems");
            });

            modelBuilder.Entity<CrossSectionOutlineAssignements>(entity =>
            {
                entity.HasKey(e => e.PkCrossSectionOutlineAssignement)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkCrossSectionOutlineAssignement).HasColumnName("Pk_CrossSectionOutlineAssignement");

                entity.Property(e => e.FkAxisReferenceSystem).HasColumnName("Fk_AxisReferenceSystem");

                entity.Property(e => e.FkCrossSectionOutline).HasColumnName("Fk_CrossSectionOutline");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.HasOne(d => d.FkAxisReferenceSystemNavigation)
                    .WithMany(p => p.CrossSectionOutlineAssignements)
                    .HasForeignKey(d => d.FkAxisReferenceSystem)
                    .HasConstraintName("AxisReferenceSystems_CrossSectionOutlineAssignements");

                entity.HasOne(d => d.FkCrossSectionOutlineNavigation)
                    .WithMany(p => p.CrossSectionOutlineAssignements)
                    .HasForeignKey(d => d.FkCrossSectionOutline)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CrossSectionOutlines_CrossSectionOutlineAssignements");
            });

            modelBuilder.Entity<CrossSectionOutlines>(entity =>
            {
                entity.HasKey(e => e.PkCrossSectionOutline)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkCrossSectionOutline).HasColumnName("Pk_CrossSectionOutline");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.Property(e => e.ReferencePoint1Name).HasMaxLength(200);

                entity.Property(e => e.ReferencePoint2Name).HasMaxLength(200);

                entity.Property(e => e.ReferencePoint2Y).HasDefaultValueSql("((10))");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.CrossSectionOutlines)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_CrossSectionOutlines");
            });

            modelBuilder.Entity<DashboardConfigurations>(entity =>
            {
                entity.HasKey(e => e.PkDashboardConfiguration)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUser)
                    .HasName("WidgetsConfigurations_Fk_User")
                    .IsUnique();

                entity.Property(e => e.PkDashboardConfiguration).HasColumnName("Pk_DashboardConfiguration");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.NumberOfColums).HasDefaultValueSql("((2))");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithOne(p => p.DashboardConfigurations)
                    .HasForeignKey<DashboardConfigurations>(d => d.FkUser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Users_DashboardConfigurations");
            });

            modelBuilder.Entity<DatadomainClassificationSpecifications>(entity =>
            {
                entity.HasKey(e => e.PkDatadomainClassificationSpecification)
                    .HasName("DataDomainClassificationConfigurations_Pk_DataDomainClassificationConfiguration")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkDatadomainClassificationSpecification).HasColumnName("Pk_DatadomainClassificationSpecification");

                entity.Property(e => e.FkClassificationType).HasColumnName("Fk_ClassificationType");

                entity.Property(e => e.FkClassificationUsed).HasColumnName("Fk_Classification_Used");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.HasOne(d => d.FkClassificationTypeNavigation)
                    .WithMany(p => p.DatadomainClassificationSpecifications)
                    .HasForeignKey(d => d.FkClassificationType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClassificationTypes_DataDomainClassificationConfiguration");

                entity.HasOne(d => d.FkClassificationUsedNavigation)
                    .WithMany(p => p.DatadomainClassificationSpecifications)
                    .HasForeignKey(d => d.FkClassificationUsed)
                    .HasConstraintName("Classifications_DataDomainClassificationConfigurations");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.DatadomainClassificationSpecifications)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DataDomains_DataDomainClassificationConfigurations");
            });

            modelBuilder.Entity<DataDomains>(entity =>
            {
                entity.HasKey(e => e.PkDataDomain)
                    .HasName("Datadomains_Pk_DataDomain");

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("Datadomains_Fk_DataDomain");

                entity.HasIndex(e => e.FkFeatureDataDomainDetails)
                    .HasName("DataDomains_Fk_Feature_DataDomainDetails");

                entity.Property(e => e.PkDataDomain).HasColumnName("Pk_DataDomain");

                entity.Property(e => e.AxisReferenceSystemCanBeChanged)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkAxisReferenceSystemDefault).HasColumnName("Fk_AxisReferenceSystem_Default");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkFeatureDataDomainDetails).HasColumnName("Fk_Feature_DataDomainDetails");

                entity.Property(e => e.GeodeticCoordinateSystemCanBeChanged)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocalCoordinateSystemCanBeChanged)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ProjectedCoordinateSystemCanBeChanged)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.FkAxisReferenceSystemDefaultNavigation)
                    .WithMany(p => p.DataDomains)
                    .HasForeignKey(d => d.FkAxisReferenceSystemDefault)
                    .HasConstraintName("AxisReferenceSystem_DataDomain_DefaultAxisReferenceSystem");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.InverseFkDataDomainNavigation)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("Datadomains_Datadomains_Parent");

                entity.HasOne(d => d.FkFeatureDataDomainDetailsNavigation)
                    .WithMany(p => p.DataDomains)
                    .HasForeignKey(d => d.FkFeatureDataDomainDetails)
                    .HasConstraintName("Features_DataDomains_DataDomainDetails");
            });

            modelBuilder.Entity<Dems>(entity =>
            {
                entity.HasKey(e => e.PkDem)
                    .HasName("DEMs_PK_DEMs")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkCoordinateSystem)
                    .HasName("DEMs_Fk_CoordinateSystem");

                entity.HasIndex(e => e.SequenceNumber)
                    .HasName("DEMs_SequenceNumber");

                entity.Property(e => e.PkDem).HasColumnName("Pk_Dem");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkCoordinateSystem).HasColumnName("Fk_CoordinateSystem");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkCoordinateSystemNavigation)
                    .WithMany(p => p.Dems)
                    .HasForeignKey(d => d.FkCoordinateSystem)
                    .HasConstraintName("CoordinateSystems_Dems");
            });

            modelBuilder.Entity<DemTiles>(entity =>
            {
                entity.HasKey(e => e.PkDemTile)
                    .HasName("DemTiles_PK_DemTile")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkDem)
                    .HasName("DemTiles_Fk_Dem");

                entity.Property(e => e.PkDemTile).HasColumnName("Pk_DemTile");

                entity.Property(e => e.ElevationValues).IsRequired();

                entity.Property(e => e.FkDem).HasColumnName("Fk_Dem");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.HasOne(d => d.FkDemNavigation)
                    .WithMany(p => p.DemTiles)
                    .HasForeignKey(d => d.FkDem)
                    .HasConstraintName("Dems_DemTiles");
            });

            modelBuilder.Entity<DerivedQuantityParts>(entity =>
            {
                entity.HasKey(e => e.PkDerivedQuantityPart)
                    .HasName("DerivedQuantityParts_PK_DerivedQuantityPart")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.DerivedQuantityPartGuid)
                    .HasName("DerivedQuantityParts_DerivedQuantityPartGuid")
                    .IsUnique();

                entity.Property(e => e.PkDerivedQuantityPart).HasColumnName("Pk_DerivedQuantityPart");

                entity.Property(e => e.Exponent).HasDefaultValueSql("((1))");

                entity.Property(e => e.FkQuantityTypeBaseType).HasColumnName("Fk_QuantityType_BaseType");

                entity.Property(e => e.FkQuantityTypeIsPartOf).HasColumnName("Fk_QuantityType_IsPartOf");

                entity.Property(e => e.IntName).HasMaxLength(200);

                entity.HasOne(d => d.FkQuantityTypeBaseTypeNavigation)
                    .WithMany(p => p.DerivedQuantityPartsFkQuantityTypeBaseTypeNavigation)
                    .HasForeignKey(d => d.FkQuantityTypeBaseType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QuanittyTypes_QuanittyTypes_BaseType");

                entity.HasOne(d => d.FkQuantityTypeIsPartOfNavigation)
                    .WithMany(p => p.DerivedQuantityPartsFkQuantityTypeIsPartOfNavigation)
                    .HasForeignKey(d => d.FkQuantityTypeIsPartOf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QuanittyTypes_DerivedQuantityParts_IsPartOf");
            });

            modelBuilder.Entity<EventScheduleDiscreteExecutionDates>(entity =>
            {
                entity.HasKey(e => e.PkEventScheduleDiscreteExecutionDate)
                    .HasName("FixedJobExecultionDates_Pk_FixedJobExecultionDate")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkEventSchedule)
                    .HasName("FixedJobExecultionDates_Fk_EventSchedule");

                entity.Property(e => e.PkEventScheduleDiscreteExecutionDate).HasColumnName("Pk_EventScheduleDiscreteExecutionDate");

                entity.Property(e => e.FkEventSchedule).HasColumnName("Fk_EventSchedule");

                entity.HasOne(d => d.FkEventScheduleNavigation)
                    .WithMany(p => p.EventScheduleDiscreteExecutionDates)
                    .HasForeignKey(d => d.FkEventSchedule)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("EventSchedules_EventScheduleEntreyFixedExecutionDates");
            });

            modelBuilder.Entity<EventSchedulePauses>(entity =>
            {
                entity.HasKey(e => e.PkEventSchedulePause)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkEventSchedule)
                    .HasName("EventSchedulePause_Fk_EventSchedule");

                entity.Property(e => e.PkEventSchedulePause).HasColumnName("Pk_EventSchedulePause");

                entity.Property(e => e.FkEventSchedule).HasColumnName("Fk_EventSchedule");

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.HasOne(d => d.FkEventScheduleNavigation)
                    .WithMany(p => p.EventSchedulePauses)
                    .HasForeignKey(d => d.FkEventSchedule)
                    .HasConstraintName("EventScheduleEntries_EventScheduleEntryPauses");
            });

            modelBuilder.Entity<EventSchedules>(entity =>
            {
                entity.HasKey(e => e.PkEventSchedule)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.EndDate)
                    .HasName("EventSchedules_EndDate");

                entity.HasIndex(e => e.FkObservationPlan)
                    .HasName("EventSchedules_Fk_ObservationPlan");

                entity.HasIndex(e => e.FkStoredJobDefinition)
                    .HasName("EventSchedules_Fk_StoredJobDefinition");

                entity.HasIndex(e => e.StartDate)
                    .HasName("EventSchedules_StartDate");

                entity.Property(e => e.PkEventSchedule).HasColumnName("Pk_EventSchedule");

                entity.Property(e => e.DaysOfMonth)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.DaysOfWeek)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FkObservationPlan).HasColumnName("Fk_ObservationPlan");

                entity.Property(e => e.FkStoredJobDefinition).HasColumnName("Fk_StoredJobDefinition");

                entity.Property(e => e.HoursOfDay)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.MinutesOfHour)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.MonthOfYear)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.TimeZoneId).HasMaxLength(200);

                entity.HasOne(d => d.FkObservationPlanNavigation)
                    .WithMany(p => p.EventSchedules)
                    .HasForeignKey(d => d.FkObservationPlan)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ObservationPlans_EventScheduleEntry");

                entity.HasOne(d => d.FkStoredJobDefinitionNavigation)
                    .WithMany(p => p.EventSchedules)
                    .HasForeignKey(d => d.FkStoredJobDefinition)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("StoredJobDefinitions_EventScheduleEntries");
            });

            modelBuilder.Entity<FeatureAlgorithmMembers>(entity =>
            {
                entity.HasKey(e => e.PkFeatureCalculationMember)
                    .HasName("FeatureAlgorithmMembers_Pk_FeatureAlgorithmMember")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeatureCalculatedFeature)
                    .HasName("FeatureAlgorithmMembers_Fk_Feature_Group");

                entity.HasIndex(e => e.FkFeatureSourceFeature)
                    .HasName("FeatureAlgorithmMembers_Fk_Feature_Member");

                entity.Property(e => e.PkFeatureCalculationMember).HasColumnName("Pk_FeatureCalculationMember");

                entity.Property(e => e.FkFeatureCalculatedFeature).HasColumnName("Fk_Feature_CalculatedFeature");

                entity.Property(e => e.FkFeatureSourceFeature).HasColumnName("Fk_Feature_SourceFeature");

                entity.HasOne(d => d.FkFeatureCalculatedFeatureNavigation)
                    .WithMany(p => p.FeatureAlgorithmMembersFkFeatureCalculatedFeatureNavigation)
                    .HasForeignKey(d => d.FkFeatureCalculatedFeature)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Features_FeatureAlgorithmMembers_CalculatedFeature");

                entity.HasOne(d => d.FkFeatureSourceFeatureNavigation)
                    .WithMany(p => p.FeatureAlgorithmMembersFkFeatureSourceFeatureNavigation)
                    .HasForeignKey(d => d.FkFeatureSourceFeature)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Features_FeatureAlgorithmMembers_SourceFeature");
            });

            modelBuilder.Entity<FeatureConfigurations>(entity =>
            {
                entity.HasKey(e => e.PkFeatureConfiguration)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkFeatureConfiguration).HasColumnName("Pk_FeatureConfiguration");

                entity.Property(e => e.FkPropertyStructure).HasColumnName("Fk_PropertyStructure");

                entity.Property(e => e.ObservationResultTimestampDisplayName).HasMaxLength(200);

                entity.Property(e => e.ObservationSamplingTimestampDisplayName).HasMaxLength(200);

                entity.Property(e => e.UseObservationErroneousFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UseObservationResultTimestamp)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UseObservationSamplingTimestamp)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UseObservationSensor)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.FkPropertyStructureNavigation)
                    .WithMany(p => p.FeatureConfigurations)
                    .HasForeignKey(d => d.FkPropertyStructure)
                    .HasConstraintName("PropertyStructures_FeatureConfigurations");
            });

            modelBuilder.Entity<FeatureCreationTemplates>(entity =>
            {
                entity.HasKey(e => e.PkFeatureCreationTemplate)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkFeatureCreationTemplate).HasColumnName("Pk_FeatureCreationTemplate");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.FeatureCreationTemplates)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_FeatureCreationTemplates");
            });

            modelBuilder.Entity<FeatureGroupMembers>(entity =>
            {
                entity.HasKey(e => e.PkFeatureFroupMember)
                    .HasName("FeatureGroupMembers_Pk_FeatureGroupMember")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeatureGroup)
                    .HasName("FeatureGroupMembers_Fk_Feature_Group");

                entity.HasIndex(e => e.FkFeatureMember)
                    .HasName("FeatureGroupMembers_Fk_Feature_Member");

                entity.Property(e => e.PkFeatureFroupMember).HasColumnName("Pk_FeatureFroupMember");

                entity.Property(e => e.FkFeatureGroup).HasColumnName("Fk_Feature_Group");

                entity.Property(e => e.FkFeatureMember).HasColumnName("Fk_Feature_Member");

                entity.HasOne(d => d.FkFeatureGroupNavigation)
                    .WithMany(p => p.FeatureGroupMembersFkFeatureGroupNavigation)
                    .HasForeignKey(d => d.FkFeatureGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Features_FeatureGroupMembers_Group");

                entity.HasOne(d => d.FkFeatureMemberNavigation)
                    .WithMany(p => p.FeatureGroupMembersFkFeatureMemberNavigation)
                    .HasForeignKey(d => d.FkFeatureMember)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Features_FeatureGroupMembers_Member");
            });

            modelBuilder.Entity<FeatureLinkPropertyValues>(entity =>
            {
                entity.HasKey(e => e.PkFeatureLinkPropertyValue)
                    .HasName("FeatureLinkPropertyValues_PK_FeatureLinkPropertyValues");

                entity.HasIndex(e => e.FkFeature)
                    .HasName("FeatureLinkPropertyValues_Fk_Feature");

                entity.HasIndex(e => e.FkProperty)
                    .HasName("FeatureLinkPropertyValues_Fk_Property");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("FeatureLinkPropertyValues_Fk_PropertyStructureInstance");

                entity.Property(e => e.PkFeatureLinkPropertyValue).HasColumnName("Pk_FeatureLinkPropertyValue");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.FeatureLinkPropertyValues)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Features_FeatureLinkPropertyValues");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.FeatureLinkPropertyValues)
                    .HasForeignKey(d => d.FkProperty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Properties_FeatureLinkPropertyValues");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.FeatureLinkPropertyValues)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyStructureInstances_FeatureLinkPropertyValues");
            });

            modelBuilder.Entity<FeatureLinks>(entity =>
            {
                entity.HasKey(e => e.PkFeatureLink)
                    .HasName("FeatureLinks_Pk_FeatureLink")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeature)
                    .HasName("FeatureLinks_Fk_Feature");

                entity.HasIndex(e => e.FkFeatureDestination)
                    .HasName("FeatureLinks_Fk_Feature_Destination");

                entity.HasIndex(e => e.FkObservation)
                    .HasName("FeatureLinks_Fk_Observation");

                entity.HasIndex(e => e.PropertyStructureInstanceGuid)
                    .HasName("FeatureLinks_PropertyStructureInstanceGuid");

                entity.Property(e => e.PkFeatureLink).HasColumnName("Pk_FeatureLink");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkFeatureDestination).HasColumnName("Fk_Feature_Destination");

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.FeatureLinksFkFeatureNavigation)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Feature_FeatureLinks_Parent");

                entity.HasOne(d => d.FkFeatureDestinationNavigation)
                    .WithMany(p => p.FeatureLinksFkFeatureDestinationNavigation)
                    .HasForeignKey(d => d.FkFeatureDestination)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Feature_FeatureLinks_Child");

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithMany(p => p.FeatureLinks)
                    .HasForeignKey(d => d.FkObservation)
                    .HasConstraintName("Observations_FeatureLinks");
            });

            modelBuilder.Entity<FeatureNetworkMembers>(entity =>
            {
                entity.HasKey(e => e.PkFeatureNetworkMember)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeatureMember)
                    .HasName("FeatureNetworkMembers_Fk_Feature_Member");

                entity.HasIndex(e => e.FkFeatureNetwork)
                    .HasName("FeatureNetworkMembers_Fk_Feature_Network");

                entity.HasIndex(e => e.FkFeatureNetworkMemberConnectedFrom)
                    .HasName("FeatureNetworkMembers_Fk_FeatureNetworkMember_ConnectedFrom");

                entity.HasIndex(e => e.FkFeatureNetworkMemberConnectedTo)
                    .HasName("FeatureNetworkMembers_Fk_FeatureNetworkMember_ConnectedTo");

                entity.Property(e => e.PkFeatureNetworkMember).HasColumnName("Pk_FeatureNetworkMember");

                entity.Property(e => e.FkFeatureMember).HasColumnName("Fk_Feature_Member");

                entity.Property(e => e.FkFeatureNetwork).HasColumnName("Fk_Feature_Network");

                entity.Property(e => e.FkFeatureNetworkMemberConnectedFrom).HasColumnName("Fk_FeatureNetworkMember_ConnectedFrom");

                entity.Property(e => e.FkFeatureNetworkMemberConnectedTo).HasColumnName("Fk_FeatureNetworkMember_ConnectedTo");

                entity.HasOne(d => d.FkFeatureMemberNavigation)
                    .WithMany(p => p.FeatureNetworkMembersFkFeatureMemberNavigation)
                    .HasForeignKey(d => d.FkFeatureMember)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Features_FeatureNetworkMembers_Member");

                entity.HasOne(d => d.FkFeatureNetworkNavigation)
                    .WithMany(p => p.FeatureNetworkMembersFkFeatureNetworkNavigation)
                    .HasForeignKey(d => d.FkFeatureNetwork)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Features_FeatureNetworkMembers_Network");

                entity.HasOne(d => d.FkFeatureNetworkMemberConnectedFromNavigation)
                    .WithMany(p => p.InverseFkFeatureNetworkMemberConnectedFromNavigation)
                    .HasForeignKey(d => d.FkFeatureNetworkMemberConnectedFrom)
                    .HasConstraintName("FeatureNetworkMembers_FeatureNetworkMembers_ConnectedFrom");

                entity.HasOne(d => d.FkFeatureNetworkMemberConnectedToNavigation)
                    .WithMany(p => p.InverseFkFeatureNetworkMemberConnectedToNavigation)
                    .HasForeignKey(d => d.FkFeatureNetworkMemberConnectedTo)
                    .HasConstraintName("FeatureNetworkMembers_FeatureNetworkMembers_ConnectedTo");
            });

            modelBuilder.Entity<Features>(entity =>
            {
                entity.HasKey(e => e.PkFeature)
                    .HasName("Features_Pk_Feature");

                entity.HasIndex(e => e.CreatedOn)
                    .HasName("Features_CreatedOn");

                entity.HasIndex(e => e.FkAxisReferenceSystem)
                    .HasName("Features_Fk_AxisReferenceSystem");

                entity.HasIndex(e => e.FkCoordinateSystem)
                    .HasName("Features_CoordinateSystem");

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("Features_Fk_DataDomain");

                entity.HasIndex(e => e.FkFeatureContainer)
                    .HasName("Features_Fk_Feature_Container");

                entity.HasIndex(e => e.FkFeatureSubtype)
                    .HasName("Features_Fk_FeatureSubtype");

                entity.HasIndex(e => e.FkFeatureType)
                    .HasName("Features_Fk_FeatureType");

                entity.HasIndex(e => e.FkImportSession)
                    .HasName("Features_Fk_importSession");

                entity.HasIndex(e => e.Guid)
                    .HasName("Features_Guid");

                entity.HasIndex(e => e.Name)
                    .HasName("Features_Name");

                entity.Property(e => e.PkFeature).HasColumnName("Pk_Feature");

                entity.Property(e => e.BeingSpied)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ContainerLsooffsetA).HasColumnName("ContainerLSOOffsetA");

                entity.Property(e => e.ContainerLsooffsetB).HasColumnName("ContainerLSOOffsetB");

                entity.Property(e => e.ContainerLsooffsetC).HasColumnName("ContainerLSOOffsetC");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkAxisReferenceSystem).HasColumnName("Fk_AxisReferenceSystem");

                entity.Property(e => e.FkCoordinateSystem).HasColumnName("Fk_CoordinateSystem");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkFeatureCalculationFeatureDataSource).HasColumnName("Fk_Feature_CalculationFeatureDataSource");

                entity.Property(e => e.FkFeatureContainer).HasColumnName("Fk_Feature_Container");

                entity.Property(e => e.FkFeatureInstantiatedFrom).HasColumnName("Fk_Feature_InstantiatedFrom");

                entity.Property(e => e.FkFeatureSubtype).HasColumnName("Fk_FeatureSubtype");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.Property(e => e.FkImportSession).HasColumnName("Fk_ImportSession");

                entity.Property(e => e.FkObservationNumberingDefinition).HasColumnName("Fk_ObservationNumberingDefinition");

                entity.Property(e => e.FkSensorDefault).HasColumnName("Fk_Sensor_Default");

                entity.Property(e => e.FkUserCalculationAlgorithmOwner).HasColumnName("Fk_User_CalculationAlgorithmOwner");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UseContainerLso).HasColumnName("UseContainerLSO");

                entity.HasOne(d => d.FkAxisReferenceSystemNavigation)
                    .WithMany(p => p.Features)
                    .HasForeignKey(d => d.FkAxisReferenceSystem)
                    .HasConstraintName("AxisReferenceSystems_Features");

                entity.HasOne(d => d.FkCoordinateSystemNavigation)
                    .WithMany(p => p.Features)
                    .HasForeignKey(d => d.FkCoordinateSystem)
                    .HasConstraintName("CoordinateSystems_Features");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.Features)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Datadomains_Features");

                entity.HasOne(d => d.FkFeatureCalculationFeatureDataSourceNavigation)
                    .WithMany(p => p.InverseFkFeatureCalculationFeatureDataSourceNavigation)
                    .HasForeignKey(d => d.FkFeatureCalculationFeatureDataSource)
                    .HasConstraintName("Features_Features_CalculationFeatureDataSource");

                entity.HasOne(d => d.FkFeatureContainerNavigation)
                    .WithMany(p => p.InverseFkFeatureContainerNavigation)
                    .HasForeignKey(d => d.FkFeatureContainer)
                    .HasConstraintName("Features_Features_ContainedIn");

                entity.HasOne(d => d.FkFeatureInstantiatedFromNavigation)
                    .WithMany(p => p.InverseFkFeatureInstantiatedFromNavigation)
                    .HasForeignKey(d => d.FkFeatureInstantiatedFrom)
                    .HasConstraintName("Features_Features_InstantiatedFrom");

                entity.HasOne(d => d.FkFeatureSubtypeNavigation)
                    .WithMany(p => p.Features)
                    .HasForeignKey(d => d.FkFeatureSubtype)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FeatureSubtypes_Features");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.Features)
                    .HasForeignKey(d => d.FkFeatureType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FeatureTypes_Features");

                entity.HasOne(d => d.FkImportSessionNavigation)
                    .WithMany(p => p.Features)
                    .HasForeignKey(d => d.FkImportSession)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ImportSessions_Features");

                entity.HasOne(d => d.FkObservationNumberingDefinitionNavigation)
                    .WithMany(p => p.Features)
                    .HasForeignKey(d => d.FkObservationNumberingDefinition)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ObservationNumberingDefinitions_Features");

                entity.HasOne(d => d.FkSensorDefaultNavigation)
                    .WithMany(p => p.Features)
                    .HasForeignKey(d => d.FkSensorDefault)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("Sensors_Featues_DefaultSensor");

                entity.HasOne(d => d.FkUserCalculationAlgorithmOwnerNavigation)
                    .WithMany(p => p.Features)
                    .HasForeignKey(d => d.FkUserCalculationAlgorithmOwner)
                    .HasConstraintName("Users_Features_CalculationAlgorithmOwner");
            });

            modelBuilder.Entity<FeatureSetMembers>(entity =>
            {
                entity.HasKey(e => new { e.FkFeatureSet, e.FkFeature })
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.FkFeatureSet).HasColumnName("Fk_FeatureSet");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.FeatureSetMembers)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Features_FeatureSetMembers");

                entity.HasOne(d => d.FkFeatureSetNavigation)
                    .WithMany(p => p.FeatureSetMembers)
                    .HasForeignKey(d => d.FkFeatureSet)
                    .HasConstraintName("FeatureSets_FeatureSetMembers");
            });

            modelBuilder.Entity<FeatureSets>(entity =>
            {
                entity.HasKey(e => e.PkFeatureSet)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUser)
                    .HasName("FeatureSets_Fk_User");

                entity.Property(e => e.PkFeatureSet).HasColumnName("Pk_FeatureSet");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.FeatureSets)
                    .HasForeignKey(d => d.FkUser)
                    .HasConstraintName("Users_FeatureSets");
            });

            modelBuilder.Entity<FeatureSubtypes>(entity =>
            {
                entity.HasKey(e => e.PkFeatureSubtype)
                    .HasName("FeatureSubtypes_Pk_FeatureSubtype")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("FeatureSubtypes_Fk_DataDomain");

                entity.HasIndex(e => e.FkFeatureType)
                    .HasName("FeatureSubtypes_Fk_FeatureType");

                entity.Property(e => e.PkFeatureSubtype).HasColumnName("Pk_FeatureSubtype");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.FeatureSubtypes)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DataDomains_FeatureSubtypes");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.FeatureSubtypes)
                    .HasForeignKey(d => d.FkFeatureType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FeatureTypes_FeatureSubtypes");
            });

            modelBuilder.Entity<FeatureTags>(entity =>
            {
                entity.HasKey(e => e.PkFeatureTag)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkFeatureTag).HasColumnName("Pk_FeatureTag");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.FeatureTags)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_FeatureTags");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.FeatureTags)
                    .HasForeignKey(d => d.FkFeatureType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FeatureTypes_FeatureTags");
            });

            modelBuilder.Entity<FeatureTypeApplicationConfigurations>(entity =>
            {
                entity.HasKey(e => e.PkFeatureTypeApplicationConfiguration)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ApplicationType)
                    .HasName("FeatureTypeApplicationConfigurations_AppType");

                entity.HasIndex(e => e.FkFeatureType)
                    .HasName("FeatureTypeApplicationConfigurations_Fk_FeatureType");

                entity.Property(e => e.PkFeatureTypeApplicationConfiguration).HasColumnName("Pk_FeatureTypeApplicationConfiguration");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.FeatureTypeApplicationConfigurations)
                    .HasForeignKey(d => d.FkFeatureType)
                    .HasConstraintName("FeatureTypes_FeatureTypeApplicationConfigurations");
            });

            modelBuilder.Entity<FeatureTypes>(entity =>
            {
                entity.HasKey(e => e.PkFeatureType)
                    .HasName("FeatureTypes_Pk_FeatureType");

                entity.HasIndex(e => e.FeatureTypeGuid)
                    .HasName("FeatureTypeGUID")
                    .IsUnique();

                entity.Property(e => e.PkFeatureType).HasColumnName("Pk_FeatureType");

                entity.Property(e => e.AllowObservations)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowedGeometryTypes).HasDefaultValueSql("((-1))");

                entity.Property(e => e.AllowedSpatialSystems).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CustomDescription).HasMaxLength(4000);

                entity.Property(e => e.CustomName).HasMaxLength(4000);

                entity.Property(e => e.CustomPath).HasMaxLength(4000);

                entity.Property(e => e.DescriptionGuid).HasColumnName("DescriptionGUID");

                entity.Property(e => e.FeatureTypeGuid)
                    .HasColumnName("FeatureTypeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NameGuid).HasColumnName("NameGUID");

                entity.Property(e => e.PathGuid).HasColumnName("PathGUID");
            });

            modelBuilder.Entity<FileReferences>(entity =>
            {
                entity.HasKey(e => e.PkFileReference)
                    .HasName("Pk_Filereferences");

                entity.HasIndex(e => e.FileReferenceGuid)
                    .HasName("FileReferences_FileReferenceGUID")
                    .IsUnique();

                entity.HasIndex(e => e.FkAttachement)
                    .HasName("FileReferences_Fk_Attachement")
                    .IsUnique()
                    .HasFilter("([Fk_Attachement] IS NOT NULL)");

                entity.HasIndex(e => e.FkBinaryPropertyValue)
                    .HasName("FileReferences_Fk_BinaryPropertyValue")
                    .IsUnique()
                    .HasFilter("([Fk_BinaryPropertyValue] IS NOT NULL)");

                entity.HasIndex(e => e.FkImportSessionFile)
                    .HasName("FileReferences_Fk_ImportSessionFile")
                    .IsUnique()
                    .HasFilter("([Fk_ImportSessionFile] IS NOT NULL)");

                entity.HasIndex(e => e.FkMapFileSet)
                    .HasName("FileReferences_Fk_MapFileSet");

                entity.HasIndex(e => e.FkMessageAttachment)
                    .HasName("FileReferences_Fk_MessageAttachement")
                    .IsUnique()
                    .HasFilter("([Fk_MessageAttachment] IS NOT NULL)");

                entity.HasIndex(e => e.FkOutputFile)
                    .HasName("FileReferences_Fk_OutputFile")
                    .IsUnique()
                    .HasFilter("([Fk_OutputFile] IS NOT NULL)");

                entity.HasIndex(e => e.FkStoredExportDefinitionTemplateFile)
                    .HasName("FileReferences_Fk_StoredExportDefinition")
                    .IsUnique()
                    .HasFilter("([Fk_StoredExportDefinition_TemplateFile] IS NOT NULL)");

                entity.Property(e => e.PkFileReference).HasColumnName("Pk_FileReference");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FileReferenceGuid)
                    .HasColumnName("FileReferenceGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FkAttachement).HasColumnName("Fk_Attachement");

                entity.Property(e => e.FkBinaryPropertyValue).HasColumnName("Fk_BinaryPropertyValue");

                entity.Property(e => e.FkImportSessionFile).HasColumnName("Fk_ImportSessionFile");

                entity.Property(e => e.FkMapFileSet).HasColumnName("Fk_MapFileSet");

                entity.Property(e => e.FkMessageAttachment).HasColumnName("Fk_MessageAttachment");

                entity.Property(e => e.FkOutputFile).HasColumnName("Fk_OutputFile");

                entity.Property(e => e.FkReferencedImagePropertyValue).HasColumnName("Fk_ReferencedImagePropertyValue");

                entity.Property(e => e.FkStoredExportDefinitionTemplateFile).HasColumnName("Fk_StoredExportDefinition_TemplateFile");

                entity.Property(e => e.FkUserOwner).HasColumnName("Fk_User_Owner");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.MediaType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.FkAttachementNavigation)
                    .WithOne(p => p.FileReferences)
                    .HasForeignKey<FileReferences>(d => d.FkAttachement)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Attachements_Filereferences");

                entity.HasOne(d => d.FkBinaryPropertyValueNavigation)
                    .WithOne(p => p.FileReferences)
                    .HasForeignKey<FileReferences>(d => d.FkBinaryPropertyValue)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("BinaryPropertyValues_FileReferences");

                entity.HasOne(d => d.FkImportSessionFileNavigation)
                    .WithOne(p => p.FileReferences)
                    .HasForeignKey<FileReferences>(d => d.FkImportSessionFile)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ImportedFiles_FileReferences");

                entity.HasOne(d => d.FkMapFileSetNavigation)
                    .WithMany(p => p.FileReferences)
                    .HasForeignKey(d => d.FkMapFileSet)
                    .HasConstraintName("MapFileSets_FileReferences");

                entity.HasOne(d => d.FkMessageAttachmentNavigation)
                    .WithOne(p => p.FileReferences)
                    .HasForeignKey<FileReferences>(d => d.FkMessageAttachment)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("MessageAttachments_FileReferences");

                entity.HasOne(d => d.FkOutputFileNavigation)
                    .WithOne(p => p.FileReferences)
                    .HasForeignKey<FileReferences>(d => d.FkOutputFile)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("OutputFiles_FileReferences");

                entity.HasOne(d => d.FkReferencedImagePropertyValueNavigation)
                    .WithMany(p => p.FileReferences)
                    .HasForeignKey(d => d.FkReferencedImagePropertyValue)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ReferencedImagePropertyValue_FileReferences");

                entity.HasOne(d => d.FkStoredExportDefinitionTemplateFileNavigation)
                    .WithOne(p => p.FileReferences)
                    .HasForeignKey<FileReferences>(d => d.FkStoredExportDefinitionTemplateFile)
                    .HasConstraintName("StoredExportDefinitions_FileReferences_TemplateFile");

                entity.HasOne(d => d.FkUserOwnerNavigation)
                    .WithMany(p => p.FileReferences)
                    .HasForeignKey(d => d.FkUserOwner)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Users_FileReferences");
            });

            modelBuilder.Entity<ForwardingMediaQuotas>(entity =>
            {
                entity.HasKey(e => e.PkForwardingMediaQuota)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.MediaType)
                    .HasName("Type")
                    .IsUnique();

                entity.Property(e => e.PkForwardingMediaQuota).HasColumnName("Pk_ForwardingMediaQuota");
            });

            modelBuilder.Entity<GeneralTextTemplates>(entity =>
            {
                entity.HasKey(e => e.PkGeneralTextTemplate)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.Language, e.Type })
                    .HasName("TextTemplates_CombinedUnique")
                    .IsUnique();

                entity.Property(e => e.PkGeneralTextTemplate).HasColumnName("Pk_GeneralTextTemplate");

                entity.Property(e => e.Template).IsRequired();
            });

            modelBuilder.Entity<GeographicSpatialData>(entity =>
            {
                entity.HasKey(e => e.PkGeographicSpatialDatum);

                entity.HasIndex(e => e.FkFeature)
                    .HasName("GeographicSpatialData_Fk_Feature")
                    .IsUnique()
                    .HasFilter("([Fk_Feature] IS NOT NULL)");

                entity.HasIndex(e => e.FkObservation)
                    .HasName("GeographicSpatialData_Fk_Observation")
                    .IsUnique()
                    .HasFilter("([Fk_Observation] IS NOT NULL)");

                entity.Property(e => e.PkGeographicSpatialDatum).HasColumnName("Pk_GeographicSpatialDatum");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithOne(p => p.GeographicSpatialData)
                    .HasForeignKey<GeographicSpatialData>(d => d.FkFeature)
                    .HasConstraintName("Features_GeographicSpatialData");

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithOne(p => p.GeographicSpatialData)
                    .HasForeignKey<GeographicSpatialData>(d => d.FkObservation)
                    .HasConstraintName("Observations_GeographicSpatialData");
            });

            modelBuilder.Entity<GeometricSpatialData>(entity =>
            {
                entity.HasKey(e => e.PkGeometricSpatialDatum);

                entity.HasIndex(e => e.FkFeature)
                    .HasName("GeometricSpatialData_Fk_Feature")
                    .IsUnique()
                    .HasFilter("([Fk_Feature] IS NOT NULL)");

                entity.HasIndex(e => e.FkObservation)
                    .HasName("GeometricSpatialData_Fk_Observation")
                    .IsUnique()
                    .HasFilter("([Fk_Observation] IS NOT NULL)");

                entity.Property(e => e.PkGeometricSpatialDatum).HasColumnName("Pk_GeometricSpatialDatum");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithOne(p => p.GeometricSpatialData)
                    .HasForeignKey<GeometricSpatialData>(d => d.FkFeature)
                    .HasConstraintName("Features_GeometricSpatialData");

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithOne(p => p.GeometricSpatialData)
                    .HasForeignKey<GeometricSpatialData>(d => d.FkObservation)
                    .HasConstraintName("Observations_GeometricSpatialData");
            });

            modelBuilder.Entity<GeometryPropertyValues>(entity =>
            {
                entity.HasKey(e => e.PkGeometryPropertyValue)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkProperty)
                    .HasName("GeometryPropertyValues_Fk_Property");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("GeometryPropertyValues_Fk_PropertyStructureInstance");

                entity.Property(e => e.PkGeometryPropertyValue).HasColumnName("Pk_GeometryPropertyValue");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.GeometryPropertyValues)
                    .HasForeignKey(d => d.FkProperty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Preoperties_GeometryPropertyValues");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.GeometryPropertyValues)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertystructureINstances_GeometryPropertyValues");
            });

            modelBuilder.Entity<HiddenClassificationElements>(entity =>
            {
                entity.HasKey(e => e.PkHiddenClassificationElement)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkHiddenClassificationElement).HasColumnName("Pk_HiddenClassificationElement");

                entity.Property(e => e.FkClassificationElement).HasColumnName("Fk_ClassificationElement");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.HasOne(d => d.FkClassificationElementNavigation)
                    .WithMany(p => p.HiddenClassificationElements)
                    .HasForeignKey(d => d.FkClassificationElement)
                    .HasConstraintName("ClassificationElements_HiddenClassificationElements");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.HiddenClassificationElements)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DataDomains_HiddenClassificationElements");
            });

            modelBuilder.Entity<HiddenFeatureTypes>(entity =>
            {
                entity.HasKey(e => new { e.FkDataDomain, e.FkFeatureType })
                    .HasName("HiddenFeatureTypes_Pk_HiddenFeatureTypes")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.HiddenFeatureTypes)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_HiddenFeatureTypes");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.HiddenFeatureTypes)
                    .HasForeignKey(d => d.FkFeatureType)
                    .HasConstraintName("FeatureTypes_HiddenFeatureTypes");
            });

            modelBuilder.Entity<HorizontalGeographicCoordinateSystems>(entity =>
            {
                entity.HasKey(e => e.PkHorizontalGeographicCoordinateSystem)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.EpsgCode)
                    .HasName("HorizontalGeographicCoordinateSystems_EpsgCode")
                    .IsUnique()
                    .HasFilter("([EpsgCode] IS NOT NULL)");

                entity.Property(e => e.PkHorizontalGeographicCoordinateSystem)
                    .HasColumnName("Pk_HorizontalGeographicCoordinateSystem")
                    .ValueGeneratedNever();

                entity.Property(e => e.AngularUnitName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LinearUnitName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Proj4Definition)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.Wkt)
                    .IsRequired()
                    .HasColumnName("WKT");
            });

            modelBuilder.Entity<Iconfiles>(entity =>
            {
                entity.HasKey(e => e.PkIconFile)
                    .HasName("Iconfiles_Pk_Iconfile")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkIconFile).HasColumnName("Pk_IconFile");

                entity.Property(e => e.FkIcon).HasColumnName("Fk_Icon");

                entity.Property(e => e.Size).HasColumnName("SIze");

                entity.HasOne(d => d.FkIconNavigation)
                    .WithMany(p => p.Iconfiles)
                    .HasForeignKey(d => d.FkIcon)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Icons_IconFiles");
            });

            modelBuilder.Entity<Icons>(entity =>
            {
                entity.HasKey(e => e.PkIcon)
                    .HasName("Icons_Pk_Icon")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkIcon).HasColumnName("Pk_Icon");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.Property(e => e.FkSensorType).HasColumnName("Fk_SensorType");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.Icons)
                    .HasForeignKey(d => d.FkFeatureType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FeatureTypes_Icons");

                entity.HasOne(d => d.FkSensorTypeNavigation)
                    .WithMany(p => p.Icons)
                    .HasForeignKey(d => d.FkSensorType)
                    .HasConstraintName("SensorTypes_Icons");
            });

            modelBuilder.Entity<ImportedFiles>(entity =>
            {
                entity.HasKey(e => e.PkImportSessionFile)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkImportSessionFile).HasColumnName("Pk_ImportSessionFile");

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.FkImportSession).HasColumnName("Fk_ImportSession");

                entity.HasOne(d => d.FkImportSessionNavigation)
                    .WithMany(p => p.ImportedFiles)
                    .HasForeignKey(d => d.FkImportSession)
                    .HasConstraintName("ImportSessions_ImportedFiles");
            });

            modelBuilder.Entity<ImportSessions>(entity =>
            {
                entity.HasKey(e => e.PkImportSession)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkImportSession).HasColumnName("Pk_ImportSession");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkStoredImportDefinition).HasColumnName("Fk_StoredImportDefinition");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.HasOne(d => d.FkStoredImportDefinitionNavigation)
                    .WithMany(p => p.ImportSessions)
                    .HasForeignKey(d => d.FkStoredImportDefinition)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("StoredImportDefinitions_ImportSessions");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.ImportSessions)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_ImportSessions_Owner");
            });

            modelBuilder.Entity<MapFileSets>(entity =>
            {
                entity.HasKey(e => e.PkMapFileSet)
                    .HasName("MapFiles__PK_MapFileSet")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("MapFiles_Fk_DataDomain");

                entity.Property(e => e.PkMapFileSet).HasColumnName("Pk_MapFileSet");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkCoordinateSystem).HasColumnName("Fk_CoordinateSystem");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkCoordinateSystemNavigation)
                    .WithMany(p => p.MapFileSets)
                    .HasForeignKey(d => d.FkCoordinateSystem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CoordinateSystems_MapFileSets");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.MapFileSets)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DataDomains_MapFileSets");
            });

            modelBuilder.Entity<MappingTemplateGeometries>(entity =>
            {
                entity.HasKey(e => e.PkMappingTemplateGeometry)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkMappingTemplatePart)
                    .HasName("MappingTemplateGeometries_Fk_MappingTemplatePart");

                entity.Property(e => e.PkMappingTemplateGeometry).HasColumnName("Pk_MappingTemplateGeometry");

                entity.Property(e => e.FkMappingTemplatePart).HasColumnName("Fk_MappingTemplatePart");

                entity.Property(e => e.Label).HasMaxLength(200);

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.HasOne(d => d.FkMappingTemplatePartNavigation)
                    .WithMany(p => p.MappingTemplateGeometries)
                    .HasForeignKey(d => d.FkMappingTemplatePart)
                    .HasConstraintName("MappingTemplateParts_MappingTemplateGeometries");
            });

            modelBuilder.Entity<MappingTemplateParts>(entity =>
            {
                entity.HasKey(e => e.PkMappingTemplatePart)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkAxisReferenceSystem)
                    .HasName("MappingTemplateParts_Fk_AxisReferenceSystem");

                entity.Property(e => e.PkMappingTemplatePart).HasColumnName("Pk_MappingTemplatePart");

                entity.Property(e => e.FkAxisReferenceSystem).HasColumnName("Fk_AxisReferenceSystem");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkAxisReferenceSystemNavigation)
                    .WithMany(p => p.MappingTemplateParts)
                    .HasForeignKey(d => d.FkAxisReferenceSystem)
                    .HasConstraintName("AxisReferenceSystems_MappingTemplateParts");
            });

            modelBuilder.Entity<MessageAttachements>(entity =>
            {
                entity.HasKey(e => e.PkMessageAttachment)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkMessageAttachment).HasColumnName("Pk_MessageAttachment");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkMessage).HasColumnName("Fk_Message");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.FkMessageNavigation)
                    .WithMany(p => p.MessageAttachements)
                    .HasForeignKey(d => d.FkMessage)
                    .HasConstraintName("Messages_MessageAttachments");
            });

            modelBuilder.Entity<MessageExternalRecipients>(entity =>
            {
                entity.HasKey(e => e.PkMessageExternalRecipient)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkMessageExternalRecipient).HasColumnName("Pk_MessageExternalRecipient");

                entity.Property(e => e.DeliverryAddress).HasMaxLength(4000);

                entity.Property(e => e.FkMessage).HasColumnName("Fk_Message");

                entity.HasOne(d => d.FkMessageNavigation)
                    .WithMany(p => p.MessageExternalRecipients)
                    .HasForeignKey(d => d.FkMessage)
                    .HasConstraintName("Messages_ExternalReceipients");
            });

            modelBuilder.Entity<MessageFolders>(entity =>
            {
                entity.HasKey(e => e.PkMessageFolder)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkMessageFolder).HasColumnName("Pk_MessageFolder");

                entity.Property(e => e.FkMessageFolder).HasColumnName("Fk_MessageFolder");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkMessageFolderNavigation)
                    .WithMany(p => p.InverseFkMessageFolderNavigation)
                    .HasForeignKey(d => d.FkMessageFolder)
                    .HasConstraintName("MessageFolders_MessageFolders_ParentFolder");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.MessageFolders)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_MessageFolders");
            });

            modelBuilder.Entity<MessageForwardingLogs>(entity =>
            {
                entity.HasKey(e => e.PkMessageForwardingLog)
                    .HasName("MessageForwardingLogs_Pk_MessageForwardingLogs")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkMessageForwardingLog).HasColumnName("Pk_MessageForwardingLog");

                entity.Property(e => e.DeliveryAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FkMessageUserAssignement).HasColumnName("Fk_MessageUserAssignement");

                entity.Property(e => e.MessageDeliveryLog).HasMaxLength(4000);

                entity.HasOne(d => d.FkMessageUserAssignementNavigation)
                    .WithMany(p => p.MessageForwardingLogs)
                    .HasForeignKey(d => d.FkMessageUserAssignement)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("MessageUserAssignements_MessageForwardingLogs");
            });

            modelBuilder.Entity<MessageForwardingRules>(entity =>
            {
                entity.HasKey(e => e.PkMessageForwardingRules)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUser)
                    .HasName("MessageForwardingRules_Fk_User");

                entity.Property(e => e.PkMessageForwardingRules).HasColumnName("Pk_MessageForwardingRules");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FilterExpression).HasMaxLength(200);

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.RegularExpression).HasMaxLength(4000);

                entity.Property(e => e.SeverityTo).HasDefaultValueSql("((10))");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.MessageForwardingRules)
                    .HasForeignKey(d => d.FkUser)
                    .HasConstraintName("Users_MessageForwardingRules");
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.PkMessage)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkMessage).HasColumnName("Pk_Message");

                entity.Property(e => e.FkUserSender).HasColumnName("Fk_User_Sender");

                entity.Property(e => e.Severity).HasDefaultValueSql("((10))");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.FkUserSenderNavigation)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.FkUserSender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_Messages_Sender");
            });

            modelBuilder.Entity<MessageUserAssignements>(entity =>
            {
                entity.HasKey(e => e.PkMessageUserAssignement)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkMessageUserAssignement).HasColumnName("Pk_MessageUserAssignement");

                entity.Property(e => e.FkMessage).HasColumnName("Fk_Message");

                entity.Property(e => e.FkMessageFolder).HasColumnName("Fk_MessageFolder");

                entity.Property(e => e.FkUserAssignedTo).HasColumnName("Fk_User_AssignedTo");

                entity.HasOne(d => d.FkMessageNavigation)
                    .WithMany(p => p.MessageUserAssignements)
                    .HasForeignKey(d => d.FkMessage)
                    .HasConstraintName("Messages_MessageUserAssignements");

                entity.HasOne(d => d.FkMessageFolderNavigation)
                    .WithMany(p => p.MessageUserAssignements)
                    .HasForeignKey(d => d.FkMessageFolder)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("MessageFolders_MessageUserAssignements");

                entity.HasOne(d => d.FkUserAssignedToNavigation)
                    .WithMany(p => p.MessageUserAssignements)
                    .HasForeignKey(d => d.FkUserAssignedTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("User_MessageUserAssignements_Receipient");
            });

            modelBuilder.Entity<MlTexts>(entity =>
            {
                entity.HasKey(e => e.PkMlText)
                    .HasName("MlTexts_PK_MlTexts")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.MlTextGuid)
                    .HasName("MlTexts_MlTextGuid");

                entity.Property(e => e.PkMlText).HasColumnName("Pk_MlText");
            });

            modelBuilder.Entity<MlTextTranslations>(entity =>
            {
                entity.HasKey(e => e.PkMlTextTranslation)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkMlText)
                    .HasName("MlTextTranslations_Fk_MlText");

                entity.Property(e => e.PkMlTextTranslation).HasColumnName("Pk_MlTextTranslation");

                entity.Property(e => e.FkMlText).HasColumnName("Fk_MlText");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.FkMlTextNavigation)
                    .WithMany(p => p.MlTextTranslations)
                    .HasForeignKey(d => d.FkMlText)
                    .HasConstraintName("MlTexts_MlTextTranslations");
            });

            modelBuilder.Entity<MultiselectClassificationPropertyValues>(entity =>
            {
                entity.HasKey(e => e.PkMultiselectClassificationPropertyValue);

                entity.HasIndex(e => e.FkProperty)
                    .HasName("ClassificationPropertyValues_Fk_Property");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("ClassificationPropertyValues_Fk_PropertyStructureInstance");

                entity.Property(e => e.PkMultiselectClassificationPropertyValue).HasColumnName("Pk_MultiselectClassificationPropertyValue");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.MultiselectClassificationPropertyValues)
                    .HasForeignKey(d => d.FkProperty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Properties_MultiselectClassificationPropertyValues");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.MultiselectClassificationPropertyValues)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyStructureInstances_MultiselectClassificationPropertyValues");
            });

            modelBuilder.Entity<MultiselectClassificationPropertyValueSelections>(entity =>
            {
                entity.HasKey(e => e.PkMultiselectClassificationPropertyValueSelection);

                entity.HasIndex(e => e.FkMultiselectClassificationPropertyValue)
                    .HasName("MultiselectClassificationPRopertyValueSelections_Fk_MultiselectClassificationPropertyValue");

                entity.Property(e => e.PkMultiselectClassificationPropertyValueSelection).HasColumnName("Pk_MultiselectClassificationPropertyValueSelection");

                entity.Property(e => e.FkClassificationElement).HasColumnName("Fk_ClassificationElement");

                entity.Property(e => e.FkMultiselectClassificationPropertyValue).HasColumnName("Fk_MultiselectClassificationPropertyValue");

                entity.HasOne(d => d.FkClassificationElementNavigation)
                    .WithMany(p => p.MultiselectClassificationPropertyValueSelections)
                    .HasForeignKey(d => d.FkClassificationElement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClassificationElements_MultiselectClassificationPropertyValueSelection");

                entity.HasOne(d => d.FkMultiselectClassificationPropertyValueNavigation)
                    .WithMany(p => p.MultiselectClassificationPropertyValueSelections)
                    .HasForeignKey(d => d.FkMultiselectClassificationPropertyValue)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("MultiselectClassificationPropertyValues_MultiselectClassificationPropertyValueSelections");
            });

            modelBuilder.Entity<NotificationForwardingRules>(entity =>
            {
                entity.HasKey(e => e.PkNotificationForwardingRule)
                    .HasName("NotificationForwardingRules_Pk_NotificationForwardingRule")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUser)
                    .HasName("NotificationForwardingRules_Fk_User");

                entity.Property(e => e.PkNotificationForwardingRule).HasColumnName("Pk_NotificationForwardingRule");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.NotificationForwardingRules)
                    .HasForeignKey(d => d.FkUser)
                    .HasConstraintName("UserAccounts_NotficationForwardingRules");
            });

            modelBuilder.Entity<NumericPropertyValues>(entity =>
            {
                entity.HasKey(e => e.PkNumericPropertyValue)
                    .HasName("NumericPropertyValues_Pk_NumericalPropertyValue");

                entity.HasIndex(e => e.FkProperty)
                    .HasName("NumericPropertyValues_Fk_Property");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("NumericPropertyValues_Fk_PropertyStructureInstance");

                entity.HasIndex(e => e.Value)
                    .HasName("NumericPropertyValues_Value");

                entity.Property(e => e.PkNumericPropertyValue).HasColumnName("Pk_NumericPropertyValue");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.NumericPropertyValues)
                    .HasForeignKey(d => d.FkProperty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Properties_NumericPropertyValues");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.NumericPropertyValues)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyStructureInstances_NumericPropertyValues");
            });

            modelBuilder.Entity<ObservationAlarmAcknowledgingObligations>(entity =>
            {
                entity.HasKey(e => e.PkObservationAlarmAcknowledgingObligation)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkObservationAlarmAcknowledgingObligation).HasColumnName("Pk_ObservationAlarmAcknowledgingObligation");

                entity.Property(e => e.FkObservationAlarm).HasColumnName("Fk_ObservationAlarm");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.HasOne(d => d.FkObservationAlarmNavigation)
                    .WithMany(p => p.ObservationAlarmAcknowledgingObligations)
                    .HasForeignKey(d => d.FkObservationAlarm)
                    .HasConstraintName("ObservationAlarms_ObservationAlarmAcknowledgingObligations");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.ObservationAlarmAcknowledgingObligations)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_ObservationAlarmAcknowledgingObligations");
            });

            modelBuilder.Entity<ObservationAlarms>(entity =>
            {
                entity.HasKey(e => e.PkObservationAlarm)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkObservation)
                    .HasName("Fk_Observation");

                entity.Property(e => e.PkObservationAlarm).HasColumnName("Pk_ObservationAlarm");

                entity.Property(e => e.AcknowledgingNotes).HasMaxLength(200);

                entity.Property(e => e.Action).HasMaxLength(4000);

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.Property(e => e.FkObservationSpyingDefinition).HasColumnName("Fk_ObservationSpyingDefinition");

                entity.Property(e => e.FkUserAcknowledgedBy).HasColumnName("Fk_User_AcknowledgedBy");

                entity.Property(e => e.OriginallyAcknowledgedBy).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithMany(p => p.ObservationAlarms)
                    .HasForeignKey(d => d.FkObservation)
                    .HasConstraintName("Observations_ObservationAlarms");

                entity.HasOne(d => d.FkObservationSpyingDefinitionNavigation)
                    .WithMany(p => p.ObservationAlarms)
                    .HasForeignKey(d => d.FkObservationSpyingDefinition)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ObservationSpyingDefinitions_ObservationAlarms");

                entity.HasOne(d => d.FkUserAcknowledgedByNavigation)
                    .WithMany(p => p.ObservationAlarms)
                    .HasForeignKey(d => d.FkUserAcknowledgedBy)
                    .HasConstraintName("Users_ObservationAlarms");
            });

            modelBuilder.Entity<ObservationNumberingDefinitions>(entity =>
            {
                entity.HasKey(e => e.PkObservationNumberingDefinition)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("FK_DataDomain");

                entity.Property(e => e.PkObservationNumberingDefinition).HasColumnName("Pk_ObservationNumberingDefinition");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.Increment).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Seed).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.ObservationNumberingDefinitions)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_SequenceDefinitions");
            });

            modelBuilder.Entity<ObservationPlans>(entity =>
            {
                entity.HasKey(e => e.PkObservationPlan)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkContainerContextSetting)
                    .HasName("ObservationPlans_Fk_ContainerContextSetting");

                entity.Property(e => e.PkObservationPlan).HasColumnName("Pk_ObservationPlan");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkContainerContextSetting).HasColumnName("Fk_ContainerContextSetting");

                entity.Property(e => e.MaximumResponseTime).HasDefaultValueSql("((604800))");

                entity.Property(e => e.MinimumObservations).HasDefaultValueSql("((1))");

                entity.Property(e => e.MinimumResponseTime).HasDefaultValueSql("((3600))");

                entity.Property(e => e.Month).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SimpleTimeIntervalsType).HasDefaultValueSql("((2))");

                entity.Property(e => e.Timespan).HasDefaultValueSql("((86400))");

                entity.HasOne(d => d.FkContainerContextSettingNavigation)
                    .WithMany(p => p.ObservationPlans)
                    .HasForeignKey(d => d.FkContainerContextSetting)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ContainerContextSettings_ObservationPlans");
            });

            modelBuilder.Entity<ObservationPlanViolations>(entity =>
            {
                entity.HasKey(e => e.PkObservationPlanViolation)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeature)
                    .HasName("ObservationPlanViolations_Fk_Feature");

                entity.HasIndex(e => e.FkObservationPlan)
                    .HasName("ObservationPlanViolations_Fk_ObservationPlan");

                entity.Property(e => e.PkObservationPlanViolation).HasColumnName("Pk_ObservationPlanViolation");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkObservationPlan).HasColumnName("Fk_ObservationPlan");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.ObservationPlanViolations)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Features_ObservationPlanViolations");

                entity.HasOne(d => d.FkObservationPlanNavigation)
                    .WithMany(p => p.ObservationPlanViolations)
                    .HasForeignKey(d => d.FkObservationPlan)
                    .HasConstraintName("ObservationPlans_ObservationPlanViolations");
            });

            modelBuilder.Entity<Observations>(entity =>
            {
                entity.HasKey(e => e.PkObservation)
                    .HasName("Observations_Pk_Observation");

                entity.HasIndex(e => e.ApprovalStatus)
                    .HasName("Observations_ApprovalStatus");

                entity.HasIndex(e => e.CreatedOn)
                    .HasName("Observation_CreatedOn");

                entity.HasIndex(e => e.FkFeature)
                    .HasName("Observations_Fk_Feature");

                entity.HasIndex(e => e.FkSensor)
                    .HasName("Observations_Fk_Sensor");

                entity.HasIndex(e => e.LastUpdate)
                    .HasName("Observations_LastUpdate")
                    .HasFilter("([LastUpdate] IS NOT NULL)");

                entity.HasIndex(e => new { e.FkFeature, e.SamplingTimestamp })
                    .HasName("Observations_UniqueSamplingTimestamp")
                    .IsUnique()
                    .HasFilter("([Observations].[Deleted]=(0))");

                entity.Property(e => e.PkObservation).HasColumnName("Pk_Observation");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkImportSession).HasColumnName("Fk_ImportSession");

                entity.Property(e => e.FkSensor).HasColumnName("Fk_Sensor");

                entity.Property(e => e.FkUserLastUpdate).HasColumnName("Fk_User_LastUpdate");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.Observations)
                    .HasForeignKey(d => d.FkFeature)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Features_Observations");

                entity.HasOne(d => d.FkImportSessionNavigation)
                    .WithMany(p => p.Observations)
                    .HasForeignKey(d => d.FkImportSession)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ImportSessions_Observations");

                entity.HasOne(d => d.FkSensorNavigation)
                    .WithMany(p => p.Observations)
                    .HasForeignKey(d => d.FkSensor)
                    .HasConstraintName("Sensors_Observations");

                entity.HasOne(d => d.FkUserLastUpdateNavigation)
                    .WithMany(p => p.Observations)
                    .HasForeignKey(d => d.FkUserLastUpdate)
                    .HasConstraintName("Users_Observations_LastUpdatedBy");
            });

            modelBuilder.Entity<ObservationSpyingDefinitions>(entity =>
            {
                entity.HasKey(e => e.PkObservationSpyingDefinition)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkContainerContextSetting)
                    .HasName("ObservationSpyingDefinitions_Fk_ContainerContextSetting");

                entity.Property(e => e.PkObservationSpyingDefinition).HasColumnName("Pk_ObservationSpyingDefinition");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkContainerContextSetting).HasColumnName("Fk_ContainerContextSetting");

                entity.Property(e => e.FkUserOwner).HasColumnName("Fk_User_Owner");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkContainerContextSettingNavigation)
                    .WithMany(p => p.ObservationSpyingDefinitions)
                    .HasForeignKey(d => d.FkContainerContextSetting)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ContainerContextSettings_ObservationSpyingDefinitions");

                entity.HasOne(d => d.FkUserOwnerNavigation)
                    .WithMany(p => p.ObservationSpyingDefinitions)
                    .HasForeignKey(d => d.FkUserOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_ObservationSpyingDefinitions");
            });

            modelBuilder.Entity<ObservationTags>(entity =>
            {
                entity.HasKey(e => e.PkObservationTag)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkObservationTag).HasColumnName("Pk_ObservationTag");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.ObservationTags)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("Domains_ObservationTags");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.ObservationTags)
                    .HasForeignKey(d => d.FkFeatureType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FeatureTypes_ObservationTags");
            });

            modelBuilder.Entity<OutputFiles>(entity =>
            {
                entity.HasKey(e => e.PkOutputFile)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUserOwner)
                    .HasName("OutputFiles_Fk_User_Owner");

                entity.HasIndex(e => e.GenerationStartDate)
                    .HasName("OutputFiles_GenerationDate");

                entity.Property(e => e.PkOutputFile).HasColumnName("Pk_OutputFile");

                entity.Property(e => e.FkUserOwner).HasColumnName("Fk_User_Owner");

                entity.HasOne(d => d.FkUserOwnerNavigation)
                    .WithMany(p => p.OutputFiles)
                    .HasForeignKey(d => d.FkUserOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_Outputfiles");
            });

            modelBuilder.Entity<Patterns>(entity =>
            {
                entity.HasKey(e => e.PkPattern)
                    .HasName("Patterns__PK_Patterns")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("Patterns_Fk_DataDomain");

                entity.Property(e => e.PkPattern).HasColumnName("Pk_Pattern");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.Patterns)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DataDomain_Patterns");
            });

            modelBuilder.Entity<PresentationTemplateBindings>(entity =>
            {
                entity.HasKey(e => e.PkPresentationTemplateBinding)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkPresentationTemplateBinding).HasColumnName("Pk_PresentationTemplateBinding");

                entity.Property(e => e.BindingDefinition).IsRequired();

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkPresentationTemplate).HasColumnName("Fk_PresentationTemplate");

                entity.Property(e => e.FkUserPrivateFor).HasColumnName("Fk_User_PrivateFor");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkPresentationTemplateNavigation)
                    .WithMany(p => p.PresentationTemplateBindings)
                    .HasForeignKey(d => d.FkPresentationTemplate)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PresentationTemplates_PresentationTemplateBindings");

                entity.HasOne(d => d.FkUserPrivateForNavigation)
                    .WithMany(p => p.PresentationTemplateBindings)
                    .HasForeignKey(d => d.FkUserPrivateFor)
                    .HasConstraintName("Users_PresentationTemplateBindings_PrivateFor");
            });

            modelBuilder.Entity<PresentationTemplates>(entity =>
            {
                entity.HasKey(e => e.PkPresentationTemplate)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkPresentationTemplate).HasColumnName("Pk_PresentationTemplate");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkUserPrivateFor).HasColumnName("Fk_User_PrivateFor");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.Property(e => e.TemplateDefinition).IsRequired();

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.PresentationTemplates)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DataDomains_PresentationTemplates");

                entity.HasOne(d => d.FkUserPrivateForNavigation)
                    .WithMany(p => p.PresentationTemplates)
                    .HasForeignKey(d => d.FkUserPrivateFor)
                    .HasConstraintName("Users_PresentationTemplates_PrivateFor");
            });

            modelBuilder.Entity<Privileges>(entity =>
            {
                entity.HasKey(e => e.PkPrivilege)
                    .HasName("Privileges_Pk_Privilege")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkPrivilege).HasColumnName("Pk_Privilege");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.FkUserGroup).HasColumnName("Fk_UserGroup");

                entity.Property(e => e.FkView).HasColumnName("Fk_View");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.Privileges)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("DataDomains_Privileges_PrivilegeObject");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.Privileges)
                    .HasForeignKey(d => d.FkFeature)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Features_Privileges");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.Privileges)
                    .HasForeignKey(d => d.FkFeatureType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FeatureTypes_Privileges");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.Privileges)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Users_Privileges");

                entity.HasOne(d => d.FkUserGroupNavigation)
                    .WithMany(p => p.Privileges)
                    .HasForeignKey(d => d.FkUserGroup)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("UserGroups_Privileges");

                entity.HasOne(d => d.FkViewNavigation)
                    .WithMany(p => p.Privileges)
                    .HasForeignKey(d => d.FkView)
                    .HasConstraintName("ViewsPrivileges");
            });

            modelBuilder.Entity<Properties>(entity =>
            {
                entity.HasKey(e => e.PkProperty)
                    .HasName("Properties_Pk_Property");

                entity.HasIndex(e => e.FkPropertyStructure)
                    .HasName("Properties_Fk_PropertyStructure");

                entity.Property(e => e.PkProperty).HasColumnName("Pk_Property");

                entity.Property(e => e.CalculationFormula)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionGuid).HasColumnName("DescriptionGUID");

                entity.Property(e => e.FkClassificationType).HasColumnName("Fk_ClassificationType");

                entity.Property(e => e.FkPropertyStructure).HasColumnName("Fk_PropertyStructure");

                entity.Property(e => e.FkQuantityType).HasColumnName("Fk_QuantityType");

                entity.Property(e => e.IdentifyingName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NameGuid).HasColumnName("NameGUID");

                entity.Property(e => e.PropertyGuid).HasColumnName("PropertyGUID");

                entity.Property(e => e.SequenceNumber).HasDefaultValueSql("((1000))");

                entity.HasOne(d => d.FkClassificationTypeNavigation)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.FkClassificationType)
                    .HasConstraintName("ClassificationTypes_Properties");

                entity.HasOne(d => d.FkPropertyStructureNavigation)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.FkPropertyStructure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyStructures_Properties");

                entity.HasOne(d => d.FkQuantityTypeNavigation)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.FkQuantityType)
                    .HasConstraintName("QuantityTypes_Properties");
            });

            modelBuilder.Entity<PropertyCollectionConfigurations>(entity =>
            {
                entity.HasKey(e => e.PkPropertyCollectionConfiguration)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkPropertyStructureConfiguration)
                    .HasName("PropertyCollectionConfigurations_Fk_PropertyStructureConfiguration");

                entity.HasIndex(e => new { e.FkPropertyCollection, e.FkPropertyStructureConfiguration })
                    .HasName("PropertyCollectionConfigurations_UniqueCombination")
                    .IsUnique();

                entity.Property(e => e.PkPropertyCollectionConfiguration).HasColumnName("Pk_PropertyCollectionConfiguration");

                entity.Property(e => e.FkPropertyCollection).HasColumnName("Fk_PropertyCollection");

                entity.Property(e => e.FkPropertyStructureConfiguration).HasColumnName("Fk_PropertyStructureConfiguration");

                entity.HasOne(d => d.FkPropertyCollectionNavigation)
                    .WithMany(p => p.PropertyCollectionConfigurations)
                    .HasForeignKey(d => d.FkPropertyCollection)
                    .HasConstraintName("PropertyCollections_PropertyCollectionConfigurations");

                entity.HasOne(d => d.FkPropertyStructureConfigurationNavigation)
                    .WithMany(p => p.PropertyCollectionConfigurations)
                    .HasForeignKey(d => d.FkPropertyStructureConfiguration)
                    .HasConstraintName("PropertyStructureConfigurations_PropertyCollectionConfigurations");
            });

            modelBuilder.Entity<PropertyCollectionMemberInstances>(entity =>
            {
                entity.HasKey(e => e.PkPropertyCollectionMemberInstance)
                    .HasName("PropertyCollectionMemberInstances_Pk_PropertyCollectionMemberInstance");

                entity.HasIndex(e => e.FkPropertyCollection)
                    .HasName("PropertyCollectionMemberInstances_Fk_PropertyCollection");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("PropertyCollectionMemberInstances_Fk_PropertyStructureInstance");

                entity.Property(e => e.PkPropertyCollectionMemberInstance).HasColumnName("Pk_PropertyCollectionMemberInstance");

                entity.Property(e => e.FkPropertyCollection).HasColumnName("Fk_PropertyCollection");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.HasOne(d => d.FkPropertyCollectionNavigation)
                    .WithMany(p => p.PropertyCollectionMemberInstances)
                    .HasForeignKey(d => d.FkPropertyCollection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyCollections_PropertyCollectionMemberInstances");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.PropertyCollectionMemberInstances)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .HasConstraintName("PropertyStructureInstances_PropertyCollectionMemberInstances");
            });

            modelBuilder.Entity<PropertyCollections>(entity =>
            {
                entity.HasKey(e => e.PkPropertyCollection)
                    .HasName("PropertyCollections_Pk_Propertycollection");

                entity.HasIndex(e => e.FkPropertyStructure)
                    .HasName("PropertyCollections_Fk_PropertyStructures_Membership");

                entity.Property(e => e.PkPropertyCollection).HasColumnName("Pk_PropertyCollection");

                entity.Property(e => e.DescriptionGuid).HasColumnName("DescriptionGUID");

                entity.Property(e => e.FkPropertyStructure).HasColumnName("Fk_PropertyStructure");

                entity.Property(e => e.IdentifyingName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NameGuid).HasColumnName("NameGUID");

                entity.Property(e => e.PropertyCollectionGuid).HasColumnName("PropertyCollectionGUID");

                entity.Property(e => e.SequenceNumber).HasDefaultValueSql("((1000))");

                entity.HasOne(d => d.FkPropertyStructureNavigation)
                    .WithMany(p => p.PropertyCollections)
                    .HasForeignKey(d => d.FkPropertyStructure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Propertystructures_Propertycollections_Containment");
            });

            modelBuilder.Entity<PropertyConfigurations>(entity =>
            {
                entity.HasKey(e => e.PkPropertyConfiguration)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkPropertyStructureConfiguration)
                    .HasName("PropertyConfigurations_Fk_PropertyStructureConfiguration");

                entity.HasIndex(e => new { e.FkPropertyStructureConfiguration, e.FkProperty })
                    .HasName("PropertyConfigurations_UniqueCombinations")
                    .IsUnique();

                entity.Property(e => e.PkPropertyConfiguration).HasColumnName("Pk_PropertyConfiguration");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureConfiguration).HasColumnName("Fk_PropertyStructureConfiguration");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.PropertyConfigurations)
                    .HasForeignKey(d => d.FkProperty)
                    .HasConstraintName("Properties_PropertyConfigurations");

                entity.HasOne(d => d.FkPropertyStructureConfigurationNavigation)
                    .WithMany(p => p.PropertyConfigurations)
                    .HasForeignKey(d => d.FkPropertyStructureConfiguration)
                    .HasConstraintName("PropertyStructureConfigurations_PropertyConfigurations");
            });

            modelBuilder.Entity<PropertyStructureConfigurationContexts>(entity =>
            {
                entity.HasKey(e => e.PkPropertyStructureConfigurationContext)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("PropertyStructureConfigurationContexts_Fk_DataDomain");

                entity.HasIndex(e => e.FkFeatureType)
                    .HasName("PropertyStructureConfigurationContexts_Dk_FeatureType");

                entity.HasIndex(e => e.FkPropertyStructureConfiguration)
                    .HasName("PropertyStructureConfigurationContexts_Fk_PropertyStructureConfiguration")
                    .IsUnique()
                    .HasFilter("([Fk_PropertyStructureConfiguration] IS NOT NULL)");

                entity.Property(e => e.PkPropertyStructureConfigurationContext).HasColumnName("Pk_PropertyStructureConfigurationContext");

                entity.Property(e => e.FkClassification).HasColumnName("Fk_Classification");

                entity.Property(e => e.FkClassificationType).HasColumnName("Fk_ClassificationType");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkFeatureConfiguration).HasColumnName("Fk_FeatureConfiguration");

                entity.Property(e => e.FkFeatureSubtype).HasColumnName("Fk_FeatureSubtype");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.Property(e => e.FkPropertyStructureConfiguration).HasColumnName("Fk_PropertyStructureConfiguration");

                entity.Property(e => e.FkSensor).HasColumnName("Fk_Sensor");

                entity.Property(e => e.FkSensorType).HasColumnName("Fk_SensorType");

                entity.HasOne(d => d.FkClassificationNavigation)
                    .WithMany(p => p.PropertyStructureConfigurationContexts)
                    .HasForeignKey(d => d.FkClassification)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Classifications_PropertyStructureConfigurationContexts");

                entity.HasOne(d => d.FkClassificationTypeNavigation)
                    .WithMany(p => p.PropertyStructureConfigurationContexts)
                    .HasForeignKey(d => d.FkClassificationType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ClassificationTypes_PropertyStructureConfigurationContexts");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.PropertyStructureConfigurationContexts)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("DataDomains_PropertyStructureConfigurationContexts");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.PropertyStructureConfigurationContexts)
                    .HasForeignKey(d => d.FkFeature)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Features_PropertyStructureConfigurationContexts");

                entity.HasOne(d => d.FkFeatureConfigurationNavigation)
                    .WithMany(p => p.PropertyStructureConfigurationContexts)
                    .HasForeignKey(d => d.FkFeatureConfiguration)
                    .HasConstraintName("FeatureConfigurations_PropertyStructureCOnfigurationContexts");

                entity.HasOne(d => d.FkFeatureSubtypeNavigation)
                    .WithMany(p => p.PropertyStructureConfigurationContexts)
                    .HasForeignKey(d => d.FkFeatureSubtype)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FeatureSubtypes_PropertyStructureConfigurationContexts");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.PropertyStructureConfigurationContexts)
                    .HasForeignKey(d => d.FkFeatureType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FeatureTypes_PropertyStructureConfigurationContexts");

                entity.HasOne(d => d.FkPropertyStructureConfigurationNavigation)
                    .WithOne(p => p.PropertyStructureConfigurationContexts)
                    .HasForeignKey<PropertyStructureConfigurationContexts>(d => d.FkPropertyStructureConfiguration)
                    .HasConstraintName("PropertyStructureConfigurations_PropertyStructureConfigurationContexts");

                entity.HasOne(d => d.FkSensorNavigation)
                    .WithMany(p => p.PropertyStructureConfigurationContexts)
                    .HasForeignKey(d => d.FkSensor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Sensors_PropertyStructureConfigurationContexts");

                entity.HasOne(d => d.FkSensorTypeNavigation)
                    .WithMany(p => p.PropertyStructureConfigurationContexts)
                    .HasForeignKey(d => d.FkSensorType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SensorTypes_PropertyStructureConfigurationContexts");
            });

            modelBuilder.Entity<PropertyStructureConfigurations>(entity =>
            {
                entity.HasKey(e => e.PkPropertyStructureConfiguration)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkPropertyStructure)
                    .HasName("PropertyStructureConfigurations_Fk_PropertyStructure");

                entity.Property(e => e.PkPropertyStructureConfiguration).HasColumnName("Pk_PropertyStructureConfiguration");

                entity.Property(e => e.FkPropertyStructure).HasColumnName("Fk_PropertyStructure");

                entity.HasOne(d => d.FkPropertyStructureNavigation)
                    .WithMany(p => p.PropertyStructureConfigurations)
                    .HasForeignKey(d => d.FkPropertyStructure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyStructures_PropertyStructureConfigurations");
            });

            modelBuilder.Entity<PropertyStructureInstances>(entity =>
            {
                entity.HasKey(e => e.PkPropertyStructureInstance)
                    .HasName("PropertystructureInstances_Pk_PropertyStructureInstance");

                entity.HasIndex(e => e.FkChronologicalSensorConfiguration)
                    .HasName("PropertystructureInstances_Fk_ChronologicalSensorConfiguration")
                    .HasFilter("([Fk_ChronologicalSensorConfiguration] IS NOT NULL)");

                entity.HasIndex(e => e.FkChronologicalSensorConfigurationFlat)
                    .HasName("PropertystructureInstances_Fk_ChronologicalSensorConfiguration_Flat")
                    .HasFilter("([Fk_ChronologicalSensorConfiguration_Flat] IS NOT NULL)");

                entity.HasIndex(e => e.FkFeature)
                    .HasName("PropertystructureInstances_Fk_Feature")
                    .IsUnique()
                    .HasFilter("([FK_Feature] IS NOT NULL)");

                entity.HasIndex(e => e.FkFeatureFlat)
                    .HasName("PropertystructureInstances_Fk_Feature_Flat")
                    .HasFilter("([FK_Feature_Flat] IS NOT NULL)");

                entity.HasIndex(e => e.FkObservation)
                    .HasName("PropertystructureInstances_Fk_Observation")
                    .IsUnique()
                    .HasFilter("([FK_Observation] IS NOT NULL)");

                entity.HasIndex(e => e.FkObservationFlat)
                    .HasName("PropertystructureInstances_Fk_Observation_Flat")
                    .HasFilter("([FK_Observation_Flat] IS NOT NULL)");

                entity.HasIndex(e => e.FkPropertyCollectionMemberInstance)
                    .HasName("PropertystructureInstances_Fk_PropertyCollectionMemberInstance")
                    .HasFilter("([Fk_PropertyCollectionMemberInstance] IS NOT NULL)");

                entity.HasIndex(e => e.FkPropertyStructure)
                    .HasName("PropertystructureInstances_Fk_PropertyStructure")
                    .HasFilter("([Fk_PropertyStructure] IS NOT NULL)");

                entity.HasIndex(e => e.FkSensor)
                    .HasName("PropertystructureInstances_Fk_Sensor")
                    .IsUnique()
                    .HasFilter("([FK_Sensor] IS NOT NULL)");

                entity.HasIndex(e => e.FkSensorFlat)
                    .HasName("PropertystructureInstances_Fk_Sensor_Flat")
                    .HasFilter("([FK_Sensor_Flat] IS NOT NULL)");

                entity.HasIndex(e => e.LastUpdatePropertyStructureInstance)
                    .HasName("PropertystructureInstances_LastUpdatePropertyStructureInstance");

                entity.Property(e => e.PkPropertyStructureInstance).HasColumnName("Pk_PropertyStructureInstance");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.FkChronologicalSensorConfiguration).HasColumnName("Fk_ChronologicalSensorConfiguration");

                entity.Property(e => e.FkChronologicalSensorConfigurationFlat).HasColumnName("Fk_ChronologicalSensorConfiguration_Flat");

                entity.Property(e => e.FkClassificationElement).HasColumnName("Fk_ClassificationElement");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkFeatureFlat).HasColumnName("Fk_Feature_Flat");

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.Property(e => e.FkObservationFlat).HasColumnName("Fk_Observation_Flat");

                entity.Property(e => e.FkObservationSensorConfiguration).HasColumnName("Fk_Observation_SensorConfiguration");

                entity.Property(e => e.FkObservationSensorConfigurationFlat).HasColumnName("Fk_Observation_SensorConfiguration_Flat");

                entity.Property(e => e.FkPropertyCollectionMemberInstance).HasColumnName("Fk_PropertyCollectionMemberInstance");

                entity.Property(e => e.FkPropertyStructure).HasColumnName("Fk_PropertyStructure");

                entity.Property(e => e.FkSensor).HasColumnName("Fk_Sensor");

                entity.Property(e => e.FkSensorFlat).HasColumnName("Fk_Sensor_Flat");

                entity.Property(e => e.PropertyStructureInstanceGuid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.FkChronologicalSensorConfigurationNavigation)
                    .WithMany(p => p.PropertyStructureInstancesFkChronologicalSensorConfigurationNavigation)
                    .HasForeignKey(d => d.FkChronologicalSensorConfiguration)
                    .HasConstraintName("ChronologicalSensorConfigurations_PropertyStructureInstances");

                entity.HasOne(d => d.FkChronologicalSensorConfigurationFlatNavigation)
                    .WithMany(p => p.PropertyStructureInstancesFkChronologicalSensorConfigurationFlatNavigation)
                    .HasForeignKey(d => d.FkChronologicalSensorConfigurationFlat)
                    .HasConstraintName("ChronologicalSensorConfigurations_PropertyStructureInstances_Flat");

                entity.HasOne(d => d.FkClassificationElementNavigation)
                    .WithMany(p => p.PropertyStructureInstances)
                    .HasForeignKey(d => d.FkClassificationElement)
                    .HasConstraintName("ClassificationElements_PropertyStructureInstances");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithOne(p => p.PropertyStructureInstancesFkFeatureNavigation)
                    .HasForeignKey<PropertyStructureInstances>(d => d.FkFeature)
                    .HasConstraintName("Feature_PropertystructureInstances");

                entity.HasOne(d => d.FkFeatureFlatNavigation)
                    .WithMany(p => p.PropertyStructureInstancesFkFeatureFlatNavigation)
                    .HasForeignKey(d => d.FkFeatureFlat)
                    .HasConstraintName("Features_PropertyStructureInstances_Flat");

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithOne(p => p.PropertyStructureInstancesFkObservationNavigation)
                    .HasForeignKey<PropertyStructureInstances>(d => d.FkObservation)
                    .HasConstraintName("Observations_PropertystructureInstances");

                entity.HasOne(d => d.FkObservationFlatNavigation)
                    .WithMany(p => p.PropertyStructureInstancesFkObservationFlatNavigation)
                    .HasForeignKey(d => d.FkObservationFlat)
                    .HasConstraintName("Observations_PropertyStructureInstances_Flat");

                entity.HasOne(d => d.FkObservationSensorConfigurationNavigation)
                    .WithMany(p => p.PropertyStructureInstancesFkObservationSensorConfigurationNavigation)
                    .HasForeignKey(d => d.FkObservationSensorConfiguration)
                    .HasConstraintName("Observations_PropertyStructureInstances_SensorConfiguration");

                entity.HasOne(d => d.FkObservationSensorConfigurationFlatNavigation)
                    .WithMany(p => p.PropertyStructureInstancesFkObservationSensorConfigurationFlatNavigation)
                    .HasForeignKey(d => d.FkObservationSensorConfigurationFlat)
                    .HasConstraintName("Observations_PropertyStructureInstances_SensorConfiguration_Flat");

                entity.HasOne(d => d.FkPropertyCollectionMemberInstanceNavigation)
                    .WithMany(p => p.PropertyStructureInstances)
                    .HasForeignKey(d => d.FkPropertyCollectionMemberInstance)
                    .HasConstraintName("PropertyCollectionMemberInstances_PropertyStructureInstances");

                entity.HasOne(d => d.FkPropertyStructureNavigation)
                    .WithMany(p => p.PropertyStructureInstances)
                    .HasForeignKey(d => d.FkPropertyStructure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Propertystructures_PropertystructureInstances");

                entity.HasOne(d => d.FkSensorNavigation)
                    .WithOne(p => p.PropertyStructureInstancesFkSensorNavigation)
                    .HasForeignKey<PropertyStructureInstances>(d => d.FkSensor)
                    .HasConstraintName("Sensors_PropertyStructureInstances");

                entity.HasOne(d => d.FkSensorFlatNavigation)
                    .WithMany(p => p.PropertyStructureInstancesFkSensorFlatNavigation)
                    .HasForeignKey(d => d.FkSensorFlat)
                    .HasConstraintName("Sensors_PropertyStructureInstances_Flat");
            });

            modelBuilder.Entity<PropertyStructures>(entity =>
            {
                entity.HasKey(e => e.PkPropertyStructure)
                    .HasName("PropertyStructures_Pk_PropertyStructure");

                entity.HasIndex(e => e.FkFeatureTypeMetadata)
                    .HasName("PropertyStructures_Fk_FeatureType_Metadata")
                    .IsUnique()
                    .HasFilter("([Fk_FeatureType_Metadata] IS NOT NULL)");

                entity.HasIndex(e => e.FkFeatureTypeObservation)
                    .HasName("PropertyStructures_Fk_FeatureType_Observation")
                    .IsUnique()
                    .HasFilter("([Fk_FeatureType_Observation] IS NOT NULL)");

                entity.HasIndex(e => e.FkPropertyCollection)
                    .HasName("PropertyStructures_Fk_PropertyCollection")
                    .IsUnique()
                    .HasFilter("([Fk_PropertyCollection] IS NOT NULL)");

                entity.HasIndex(e => e.FkSensorTypeMetadata)
                    .HasName("PropertyStructures_Fk_SensorType_Metadata")
                    .IsUnique()
                    .HasFilter("([Fk_SensorType_Metadata] IS NOT NULL)");

                entity.HasIndex(e => e.FkSensorTypeObservationConfiguration)
                    .HasName("PropertyStructures_Fk_SensorType_ObservationConfiguration")
                    .IsUnique()
                    .HasFilter("([Fk_SensorType_ObservationConfiguration] IS NOT NULL)");

                entity.Property(e => e.PkPropertyStructure).HasColumnName("Pk_PropertyStructure");

                entity.Property(e => e.FkClassificationType).HasColumnName("Fk_ClassificationType");

                entity.Property(e => e.FkFeatureTypeMetadata).HasColumnName("Fk_FeatureType_Metadata");

                entity.Property(e => e.FkFeatureTypeObservation).HasColumnName("Fk_FeatureType_Observation");

                entity.Property(e => e.FkPropertyCollection).HasColumnName("Fk_PropertyCollection");

                entity.Property(e => e.FkSensorTypeChronologicalConfiguration).HasColumnName("Fk_SensorType_ChronologicalConfiguration");

                entity.Property(e => e.FkSensorTypeMetadata).HasColumnName("Fk_SensorType_Metadata");

                entity.Property(e => e.FkSensorTypeObservationConfiguration).HasColumnName("Fk_SensorType_ObservationConfiguration");

                entity.Property(e => e.IntName).HasMaxLength(200);

                entity.Property(e => e.PropertyStructureGuid)
                    .HasColumnName("PropertyStructureGUID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.FkClassificationTypeNavigation)
                    .WithMany(p => p.PropertyStructures)
                    .HasForeignKey(d => d.FkClassificationType)
                    .HasConstraintName("ClassificationTypes_PropertyStructures");

                entity.HasOne(d => d.FkFeatureTypeMetadataNavigation)
                    .WithOne(p => p.PropertyStructuresFkFeatureTypeMetadataNavigation)
                    .HasForeignKey<PropertyStructures>(d => d.FkFeatureTypeMetadata)
                    .HasConstraintName("FeatureTypes_PropertyStructures_Metadata");

                entity.HasOne(d => d.FkFeatureTypeObservationNavigation)
                    .WithOne(p => p.PropertyStructuresFkFeatureTypeObservationNavigation)
                    .HasForeignKey<PropertyStructures>(d => d.FkFeatureTypeObservation)
                    .HasConstraintName("FeatureTypes_PropertyStructures_Observation");

                entity.HasOne(d => d.FkPropertyCollectionNavigation)
                    .WithOne(p => p.PropertyStructures)
                    .HasForeignKey<PropertyStructures>(d => d.FkPropertyCollection)
                    .HasConstraintName("PropertyCollections_PropertyStructures");

                entity.HasOne(d => d.FkSensorTypeChronologicalConfigurationNavigation)
                    .WithMany(p => p.PropertyStructuresFkSensorTypeChronologicalConfigurationNavigation)
                    .HasForeignKey(d => d.FkSensorTypeChronologicalConfiguration)
                    .HasConstraintName("SensorTypes_PropertyStructures_ChronologicalSensorConfiguration");

                entity.HasOne(d => d.FkSensorTypeMetadataNavigation)
                    .WithOne(p => p.PropertyStructuresFkSensorTypeMetadataNavigation)
                    .HasForeignKey<PropertyStructures>(d => d.FkSensorTypeMetadata)
                    .HasConstraintName("SensorTypes_PropertyStructures_Metadata");

                entity.HasOne(d => d.FkSensorTypeObservationConfigurationNavigation)
                    .WithOne(p => p.PropertyStructuresFkSensorTypeObservationConfigurationNavigation)
                    .HasForeignKey<PropertyStructures>(d => d.FkSensorTypeObservationConfiguration)
                    .HasConstraintName("SensorTypes_PropertyStructures_ObservationConfiguration");
            });

            modelBuilder.Entity<QuantityPropertyValues>(entity =>
            {
                entity.HasKey(e => e.PkQuanityPropertyValue)
                    .HasName("QuantityPropertyvalues_Pk_QuantityPropertyvalue");

                entity.HasIndex(e => e.FkProperty)
                    .HasName("QuantityPropertyValues_Fk_Property");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("QuantityPropertyCalues_Fk_PropertyStructureInstance");

                entity.HasIndex(e => e.Value)
                    .HasName("QuantityPropertyCalues_Value");

                entity.Property(e => e.PkQuanityPropertyValue).HasColumnName("Pk_QuanityPropertyValue");

                entity.Property(e => e.FkAvailableUnit).HasColumnName("Fk_AvailableUnit");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.HasOne(d => d.FkAvailableUnitNavigation)
                    .WithMany(p => p.QuantityPropertyValues)
                    .HasForeignKey(d => d.FkAvailableUnit)
                    .HasConstraintName("AvailableUnits_QuantityPropertyValues");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.QuantityPropertyValues)
                    .HasForeignKey(d => d.FkProperty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Properties_QuantityPropertyvalues");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.QuantityPropertyValues)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyStructureInstances_QuantityPropertyvalues");
            });

            modelBuilder.Entity<QuantityTypes>(entity =>
            {
                entity.HasKey(e => e.PkQuantityType)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.QuantityTypeGuid)
                    .HasName("QuantityTypes_QuanityTypeGuid")
                    .IsUnique();

                entity.Property(e => e.PkQuantityType).HasColumnName("Pk_QuantityType");

                entity.Property(e => e.ConversionDivisor).HasDefaultValueSql("((1))");

                entity.Property(e => e.ConversionMultiplicand).HasDefaultValueSql("((1))");

                entity.Property(e => e.DescriptionGuid).HasColumnName("DescriptionGUID");

                entity.Property(e => e.DimensionSymbol).HasMaxLength(10);

                entity.Property(e => e.NameGuid).HasColumnName("NameGUID");

                entity.Property(e => e.Symbol).HasMaxLength(10);
            });

            modelBuilder.Entity<QueuedJobs>(entity =>
            {
                entity.HasKey(e => e.PkQueuedJob)
                    .HasName("QueuedJobs_Pk_QueuedJob")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkStoredJobDefinition)
                    .HasName("QueuedJobs_Fk_StoredJobDefinition");

                entity.Property(e => e.PkQueuedJob).HasColumnName("Pk_QueuedJob");

                entity.Property(e => e.ExecutionPriority).HasDefaultValueSql("((10))");

                entity.Property(e => e.FkQueuedJobPredecessor).HasColumnName("Fk_QueuedJob_Predecessor");

                entity.Property(e => e.FkStoredJobDefinition).HasColumnName("Fk_StoredJobDefinition");

                entity.Property(e => e.FkUserJobowner).HasColumnName("Fk_User_Jobowner");

                entity.Property(e => e.ThreadSchedulingPriority).HasDefaultValueSql("((3))");

                entity.HasOne(d => d.FkQueuedJobPredecessorNavigation)
                    .WithMany(p => p.InverseFkQueuedJobPredecessorNavigation)
                    .HasForeignKey(d => d.FkQueuedJobPredecessor)
                    .HasConstraintName("QueuedJobs_QueuedJobs_Predecessor");

                entity.HasOne(d => d.FkStoredJobDefinitionNavigation)
                    .WithMany(p => p.QueuedJobs)
                    .HasForeignKey(d => d.FkStoredJobDefinition)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("StoredJobDefinitions_QueuedJobs");

                entity.HasOne(d => d.FkUserJobownerNavigation)
                    .WithMany(p => p.QueuedJobs)
                    .HasForeignKey(d => d.FkUserJobowner)
                    .HasConstraintName("Users_QueuedJobs");
            });

            modelBuilder.Entity<ReferencedImagePropertyValues>(entity =>
            {
                entity.HasKey(e => e.PkReferencedImagePropertyValue)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkProperty)
                    .HasName("ReferencedImagePropertyValues_Fk_Property");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("ReferencedImagePropertyValues_Fk_PropertyStructureInstance");

                entity.Property(e => e.PkReferencedImagePropertyValue).HasColumnName("Pk_ReferencedImagePropertyValue");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.ReferencedImagePropertyValues)
                    .HasForeignKey(d => d.FkProperty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Properties_ReferenceImagePropertyValues");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.ReferencedImagePropertyValues)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertystructureInstances_ReferencedImagePropertyValues");
            });

            modelBuilder.Entity<Sensors>(entity =>
            {
                entity.HasKey(e => e.PkSensor)
                    .HasName("Sensors_Pk_Sensor");

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("Sensors_Fk_DataDomain");

                entity.HasIndex(e => e.FkSensorType)
                    .HasName("Sensors_Fk_SensorType");

                entity.Property(e => e.PkSensor).HasColumnName("Pk_Sensor");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkSensorType).HasColumnName("Fk_SensorType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.Sensors)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Datadomains_Sensors");

                entity.HasOne(d => d.FkSensorTypeNavigation)
                    .WithMany(p => p.Sensors)
                    .HasForeignKey(d => d.FkSensorType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Sensortypes_Sensors");
            });

            modelBuilder.Entity<SensorTypes>(entity =>
            {
                entity.HasKey(e => e.PkSensorType)
                    .HasName("Sensortypes_Pk_SensorType")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.SensorTypeGuid)
                    .HasName("SensorTypes_SensorTypeGuid");

                entity.Property(e => e.PkSensorType).HasColumnName("Pk_SensorType");

                entity.Property(e => e.CustomDescription).HasMaxLength(4000);

                entity.Property(e => e.CustomName).HasMaxLength(4000);

                entity.Property(e => e.CustomPath).HasMaxLength(4000);

                entity.Property(e => e.DescriptionGuid).HasColumnName("DescriptionGUID");

                entity.Property(e => e.NameGuid).HasColumnName("NameGUID");

                entity.Property(e => e.PathGuid).HasColumnName("PathGUID");

                entity.Property(e => e.SensorTypeGuid)
                    .HasColumnName("SensorTypeGUID")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<SingletonSettings>(entity =>
            {
                entity.HasKey(e => e.PkSingletonSetting)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkSingletonSetting)
                    .HasColumnName("Pk_SingletonSetting")
                    .ValueGeneratedNever();

                entity.Property(e => e.GlobalSettings).IsRequired();

                entity.Property(e => e.License).IsRequired();
            });

            modelBuilder.Entity<SmartMessageFolders>(entity =>
            {
                entity.HasKey(e => e.PkSmartMessageFolder)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkSmartMessageFolder).HasColumnName("Pk_SmartMessageFolder");

                entity.Property(e => e.FilterXml)
                    .IsRequired()
                    .HasColumnName("FilterXML")
                    .HasColumnType("xml");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OrderXml)
                    .HasColumnName("OrderXML")
                    .HasColumnType("xml");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.SmartMessageFolders)
                    .HasForeignKey(d => d.FkUser)
                    .HasConstraintName("Users_SmartMessageFolders_Owns");
            });

            modelBuilder.Entity<StaticTimespans>(entity =>
            {
                entity.HasKey(e => e.PkStaticTimespan)
                    .HasName("StaticTimespans_Pk_StaticTimespan")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUser)
                    .HasName("StaticTimespans_Fk_User")
                    .IsUnique()
                    .HasFilter("([FK_User] IS NOT NULL)");

                entity.HasIndex(e => e.FkUserGroupMembership)
                    .HasName("StaticTimespans_Fk_UserGroupMembership")
                    .IsUnique()
                    .HasFilter("([Fk_UserGroupMembership] IS NOT NULL)");

                entity.Property(e => e.PkStaticTimespan).HasColumnName("Pk_StaticTimespan");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.FkUserGroupMembership).HasColumnName("Fk_UserGroupMembership");

                entity.Property(e => e.LowerBoundaryInclusive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpperBoundaryInclusive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithOne(p => p.StaticTimespans)
                    .HasForeignKey<StaticTimespans>(d => d.FkUser)
                    .HasConstraintName("Users_StaticTimespans");

                entity.HasOne(d => d.FkUserGroupMembershipNavigation)
                    .WithOne(p => p.StaticTimespans)
                    .HasForeignKey<StaticTimespans>(d => d.FkUserGroupMembership)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("UserGroupMemberships_StaticTimespans");
            });

            modelBuilder.Entity<StoredExportDefinitions>(entity =>
            {
                entity.HasKey(e => e.PkStoredExportDefinition)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("StoredExportDefinitions_Fk_DataDomain");

                entity.HasIndex(e => e.FkUserPrivateFor)
                    .HasName("StoredExportDefinitions_Fk_User_PrivateFor");

                entity.Property(e => e.PkStoredExportDefinition).HasColumnName("Pk_StoredExportDefinition");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkUserPrivateFor).HasColumnName("Fk_User_PrivateFor");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.StoredExportDefinitions)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_StoredExportDefinitions");

                entity.HasOne(d => d.FkUserPrivateForNavigation)
                    .WithMany(p => p.StoredExportDefinitions)
                    .HasForeignKey(d => d.FkUserPrivateFor)
                    .HasConstraintName("Users_StoredExportDefinitions");
            });

            modelBuilder.Entity<StoredImportDefinitions>(entity =>
            {
                entity.HasKey(e => e.PkStoredImportDefinition)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("StoredImportDefinitions_Fk_DataDomain");

                entity.HasIndex(e => e.FkUserPrivateFor)
                    .HasName("StoredImportDefinitions_Fk_User_PrivateFor");

                entity.Property(e => e.PkStoredImportDefinition).HasColumnName("Pk_StoredImportDefinition");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkUserPrivateFor).HasColumnName("Fk_User_PrivateFor");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.StoredImportDefinitions)
                    .HasForeignKey(d => d.FkDataDomain)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("DataDomains_StoredImportDefinitions");

                entity.HasOne(d => d.FkUserPrivateForNavigation)
                    .WithMany(p => p.StoredImportDefinitions)
                    .HasForeignKey(d => d.FkUserPrivateFor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Users_StoredImportDefinitions");
            });

            modelBuilder.Entity<StoredJobDefinitions>(entity =>
            {
                entity.HasKey(e => e.PkStoredJobDefinition)
                    .HasName("JobDefinitions_Pk_JobDefinition")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkStoredJobDefinition).HasColumnName("Pk_StoredJobDefinition");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.ExecutionPriority).HasDefaultValueSql("((10))");

                entity.Property(e => e.FkStoredJobDefinitionPredecessor).HasColumnName("Fk_StoredJobDefinition_Predecessor");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ThreadSchedulingPriority).HasDefaultValueSql("((3))");

                entity.HasOne(d => d.FkStoredJobDefinitionPredecessorNavigation)
                    .WithMany(p => p.InverseFkStoredJobDefinitionPredecessorNavigation)
                    .HasForeignKey(d => d.FkStoredJobDefinitionPredecessor)
                    .HasConstraintName("StoredJobDefinition_StoredJobDefinitions_Predecessor");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.StoredJobDefinitions)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_StoredJobDefinitions_Owner");
            });

            modelBuilder.Entity<StoredValidationConfigurations>(entity =>
            {
                entity.HasKey(e => e.PkStoredValidationConfiguration)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkStoredValidationConfiguration).HasColumnName("Pk_StoredValidationConfiguration");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.StoredValidationConfigurations)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_StoredValidationConfigurations");
            });

            modelBuilder.Entity<StringPropertyValues>(entity =>
            {
                entity.HasKey(e => e.PkStringPropertyValue)
                    .HasName("StringPropertyvalues_Pk_StringPropertyvalue");

                entity.HasIndex(e => e.FkProperty)
                    .HasName("StringPropertyValues_Fk_Property");

                entity.HasIndex(e => e.FkPropertyStructureInstance)
                    .HasName("StringPropertyValues_Fk_PropertyStructureInstance");

                entity.HasIndex(e => e.ValueShort)
                    .HasName("StringPropertyValues_ValueShort");

                entity.Property(e => e.PkStringPropertyValue).HasColumnName("Pk_StringPropertyValue");

                entity.Property(e => e.FkProperty).HasColumnName("Fk_Property");

                entity.Property(e => e.FkPropertyStructureInstance).HasColumnName("Fk_PropertyStructureInstance");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.Property(e => e.ValueShort)
                    .HasMaxLength(30)
                    .HasComputedColumnSql("(left(upper([Value]),(30)))");

                entity.HasOne(d => d.FkPropertyNavigation)
                    .WithMany(p => p.StringPropertyValues)
                    .HasForeignKey(d => d.FkProperty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Properties_StringpropertyValues");

                entity.HasOne(d => d.FkPropertyStructureInstanceNavigation)
                    .WithMany(p => p.StringPropertyValues)
                    .HasForeignKey(d => d.FkPropertyStructureInstance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PropertyStructureInstances_StringPropertyvalues");
            });

            modelBuilder.Entity<Taxonomies>(entity =>
            {
                entity.HasKey(e => e.PkTaxonomy)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkTaxonomy).HasColumnName("Pk_Taxonomy");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<TaxonomyTermAssignments>(entity =>
            {
                entity.HasKey(e => e.PkTaxonomyTermAssignment)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeature)
                    .HasName("TaxonomyTermAssignments_Fk_Feature");

                entity.HasIndex(e => e.FkTaxonomyTerm)
                    .HasName("TaxonomyTermAssignments_Fk_TaxonomyTerm");

                entity.Property(e => e.PkTaxonomyTermAssignment).HasColumnName("Pk_TaxonomyTermAssignment");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkTaxonomyTerm).HasColumnName("Fk_TaxonomyTerm");

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.TaxonomyTermAssignments)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Features_TaxonomyTerms");

                entity.HasOne(d => d.FkTaxonomyTermNavigation)
                    .WithMany(p => p.TaxonomyTermAssignments)
                    .HasForeignKey(d => d.FkTaxonomyTerm)
                    .HasConstraintName("TaxonomyTerms_TaxonomyTermAssignments");
            });

            modelBuilder.Entity<TaxonomyTerms>(entity =>
            {
                entity.HasKey(e => e.PkTaxonomyTerm)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkDataDomain)
                    .HasName("TaxonomyTerms_Fk_DataDomain");

                entity.HasIndex(e => e.FkTaxonomy)
                    .HasName("TaxonomyTerms_Fk_Taxonomy");

                entity.Property(e => e.PkTaxonomyTerm).HasColumnName("Pk_TaxonomyTerm");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkTaxonomy).HasColumnName("Fk_Taxonomy");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.TaxonomyTerms)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("Relation_1122");

                entity.HasOne(d => d.FkTaxonomyNavigation)
                    .WithMany(p => p.TaxonomyTerms)
                    .HasForeignKey(d => d.FkTaxonomy)
                    .HasConstraintName("Relation_1123");
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.HasKey(e => e.PkUnit)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.UnitGuid)
                    .HasName("Units_UnitGuid")
                    .IsUnique();

                entity.Property(e => e.PkUnit).HasColumnName("Pk_Unit");

                entity.Property(e => e.FkQuantityType).HasColumnName("Fk_QuantityType");

                entity.Property(e => e.IntName).HasMaxLength(200);

                entity.Property(e => e.ToBaseDivisor).HasDefaultValueSql("((1))");

                entity.Property(e => e.ToBaseMultiplicand).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitGuid).HasColumnName("UnitGUID");

                entity.HasOne(d => d.FkQuantityTypeNavigation)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.FkQuantityType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QuanittyTypes_Units");
            });

            modelBuilder.Entity<UnitSystemConversionSettings>(entity =>
            {
                entity.HasKey(e => e.PkUnitSystemConversionSetting)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkUnitSystemConversionSetting).HasColumnName("Pk_UnitSystemConversionSetting");

                entity.Property(e => e.ConversionDivisor).HasDefaultValueSql("((1))");

                entity.Property(e => e.ConversionMultiplicand).HasDefaultValueSql("((1))");

                entity.Property(e => e.FkQuantityType).HasColumnName("Fk_QuantityType");

                entity.HasOne(d => d.FkQuantityTypeNavigation)
                    .WithMany(p => p.UnitSystemConversionSettings)
                    .HasForeignKey(d => d.FkQuantityType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("QuantityTypes_UnitSystemConversionSettings");
            });

            modelBuilder.Entity<Urls>(entity =>
            {
                entity.HasKey(e => e.PkUrl)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkFeature)
                    .HasName("Urls_Fk_Feature");

                entity.HasIndex(e => e.FkObservation)
                    .HasName("Urls_Fk_Observation");

                entity.HasIndex(e => e.PropertyStructureInstanceGuid)
                    .HasName("Urls_PropertyStructureInstanceGuid");

                entity.Property(e => e.PkUrl).HasColumnName("Pk_Url");

                entity.Property(e => e.FkFeature).HasColumnName("Fk_Feature");

                entity.Property(e => e.FkObservation).HasColumnName("Fk_Observation");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.FkFeatureNavigation)
                    .WithMany(p => p.Urls)
                    .HasForeignKey(d => d.FkFeature)
                    .HasConstraintName("Features_Urls");

                entity.HasOne(d => d.FkObservationNavigation)
                    .WithMany(p => p.Urls)
                    .HasForeignKey(d => d.FkObservation)
                    .HasConstraintName("Observations_Urls");
            });

            modelBuilder.Entity<UsedClassificationTypes>(entity =>
            {
                entity.HasKey(e => e.PkUsedClassificationType)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkUsedClassificationType).HasColumnName("Pk_UsedClassificationType");

                entity.Property(e => e.FkFeatureType).HasColumnName("Fk_FeatureType");

                entity.Property(e => e.FkSensorType).HasColumnName("Fk_SensorType");

                entity.HasOne(d => d.FkFeatureTypeNavigation)
                    .WithMany(p => p.UsedClassificationTypes)
                    .HasForeignKey(d => d.FkFeatureType)
                    .HasConstraintName("FeatureTypes_UsedClassificationTypes");

                entity.HasOne(d => d.FkSensorTypeNavigation)
                    .WithMany(p => p.UsedClassificationTypes)
                    .HasForeignKey(d => d.FkSensorType)
                    .HasConstraintName("SensorTypes_UsedClassificationTypes");
            });

            modelBuilder.Entity<UserFavorites>(entity =>
            {
                entity.HasKey(e => e.PkUserFavorite);

                entity.Property(e => e.PkUserFavorite).HasColumnName("Pk_UserFavorite");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkPresentationTemplate).HasColumnName("Fk_PresentationTemplate");

                entity.Property(e => e.FkPresentationTemplateBinding).HasColumnName("Fk_PresentationTemplateBinding");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.FkView).HasColumnName("Fk_View");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkPresentationTemplateNavigation)
                    .WithMany(p => p.UserFavorites)
                    .HasForeignKey(d => d.FkPresentationTemplate)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserFavorites_PresentationTemplates");

                entity.HasOne(d => d.FkPresentationTemplateBindingNavigation)
                    .WithMany(p => p.UserFavorites)
                    .HasForeignKey(d => d.FkPresentationTemplateBinding)
                    .HasConstraintName("FK_UserFavorites_PresentationTemplateBindings");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.UserFavorites)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFavorites_Users");

                entity.HasOne(d => d.FkViewNavigation)
                    .WithMany(p => p.UserFavorites)
                    .HasForeignKey(d => d.FkView)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserFavorites_Views");
            });

            modelBuilder.Entity<UserGroupMemberships>(entity =>
            {
                entity.HasKey(e => e.PkUserGroupMembership)
                    .HasName("UserGroupMembers_Pk_UserGroupMemberShip")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUser)
                    .HasName("UserGroupMembers_Fk_User");

                entity.HasIndex(e => e.FkUserGroup)
                    .HasName("UserGroupMembers_Fk_UserGroup");

                entity.Property(e => e.PkUserGroupMembership).HasColumnName("Pk_UserGroupMembership");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.FkUserGroup).HasColumnName("Fk_UserGroup");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.UserGroupMemberships)
                    .HasForeignKey(d => d.FkUser)
                    .HasConstraintName("Users_UserGroupMembers");

                entity.HasOne(d => d.FkUserGroupNavigation)
                    .WithMany(p => p.UserGroupMemberships)
                    .HasForeignKey(d => d.FkUserGroup)
                    .HasConstraintName("UserGroups_UserGroupMembers");
            });

            modelBuilder.Entity<UserGroups>(entity =>
            {
                entity.HasKey(e => e.PkUserGroup)
                    .HasName("UserGroups_Pk_UserGroup")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkUserGroup).HasColumnName("Pk_UserGroup");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkUserGroup).HasColumnName("Fk_UserGroup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkUserGroupNavigation)
                    .WithMany(p => p.InverseFkUserGroupNavigation)
                    .HasForeignKey(d => d.FkUserGroup)
                    .HasConstraintName("UserGroups_UserGroups");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.PkUser)
                    .HasName("Users_Pk_User")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.UserName)
                    .HasName("User_UserName")
                    .IsUnique();

                entity.Property(e => e.PkUser).HasColumnName("Pk_User");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.Company).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Culture).HasDefaultValueSql("((9))");

                entity.Property(e => e.Department).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.LastModified).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.MobilePhoneNumber).HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(30);

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.PostNominalLetters).HasMaxLength(50);

                entity.Property(e => e.PreNominalLetters).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomains_Users");
            });

            modelBuilder.Entity<UserSessions>(entity =>
            {
                entity.HasKey(e => e.PkUserSession)
                    .HasName("UserSessions_Pk_UserSession")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkAuthenticationAttempt)
                    .HasName("UserSessions_Fk_AuthenticationAttempt")
                    .IsUnique();

                entity.HasIndex(e => e.FkUser)
                    .HasName("UserSessions_Fk_User");

                entity.Property(e => e.PkUserSession).HasColumnName("Pk_UserSession");

                entity.Property(e => e.ClientInformation).HasMaxLength(4000);

                entity.Property(e => e.FkAuthenticationAttempt).HasColumnName("Fk_AuthenticationAttempt");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.SessionEnd).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.SessionLastUsed).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.SessionStart).HasColumnType("datetimeoffset(2)");

                entity.HasOne(d => d.FkAuthenticationAttemptNavigation)
                    .WithOne(p => p.UserSessions)
                    .HasForeignKey<UserSessions>(d => d.FkAuthenticationAttempt)
                    .HasConstraintName("AuthenticationAttempts_UserSessions");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.UserSessions)
                    .HasForeignKey(d => d.FkUser)
                    .HasConstraintName("Users_SessionLog");
            });

            modelBuilder.Entity<ValidationResults>(entity =>
            {
                entity.HasKey(e => e.PkValidationResult)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkValidationResult).HasColumnName("Pk_ValidationResult");

                entity.Property(e => e.FkValidationResultParent).HasColumnName("Fk_ValidationResult_Parent");

                entity.Property(e => e.FkValidationRun).HasColumnName("Fk_ValidationRun");

                entity.Property(e => e.SourceObjectName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.FkValidationResultParentNavigation)
                    .WithMany(p => p.InverseFkValidationResultParentNavigation)
                    .HasForeignKey(d => d.FkValidationResultParent)
                    .HasConstraintName("ValidationResults_ValidationResults_Parent");

                entity.HasOne(d => d.FkValidationRunNavigation)
                    .WithMany(p => p.ValidationResults)
                    .HasForeignKey(d => d.FkValidationRun)
                    .HasConstraintName("ValidationRuns_ValidationResults");
            });

            modelBuilder.Entity<ValidationRuns>(entity =>
            {
                entity.HasKey(e => e.PkValidationRun)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkValidationRun).HasColumnName("Pk_ValidationRun");

                entity.Property(e => e.FkQueuedJob).HasColumnName("Fk_QueuedJob");

                entity.Property(e => e.FkStoredValidationConfiguration).HasColumnName("Fk_StoredValidationConfiguration");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ValidationConfiguration).IsRequired();

                entity.HasOne(d => d.FkQueuedJobNavigation)
                    .WithMany(p => p.ValidationRuns)
                    .HasForeignKey(d => d.FkQueuedJob)
                    .HasConstraintName("QueuedJobs_ValidationRuns");

                entity.HasOne(d => d.FkStoredValidationConfigurationNavigation)
                    .WithMany(p => p.ValidationRuns)
                    .HasForeignKey(d => d.FkStoredValidationConfiguration)
                    .HasConstraintName("StoredValidationConfigurations_ValidationRuns");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.ValidationRuns)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Users_ValidationRuns");
            });

            modelBuilder.Entity<VerticalCoordinateSystems>(entity =>
            {
                entity.HasKey(e => e.PkVerticalCoordinateSystem)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkVerticalCoordinateSystem).HasColumnName("Pk_VerticalCoordinateSystem");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LinearUnitCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LinearUnitConversionFactor).HasDefaultValueSql("((1.0))");

                entity.Property(e => e.LinearUnitName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ViewDataDomainAssociations>(entity =>
            {
                entity.HasKey(e => e.PkViewDataDomainAssociation)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkViewDataDomainAssociation).HasColumnName("Pk_ViewDataDomainAssociation");

                entity.Property(e => e.FkDataDomain).HasColumnName("Fk_DataDomain");

                entity.Property(e => e.FkView).HasColumnName("Fk_View");

                entity.HasOne(d => d.FkDataDomainNavigation)
                    .WithMany(p => p.ViewDataDomainAssociations)
                    .HasForeignKey(d => d.FkDataDomain)
                    .HasConstraintName("DataDomain_ViewDataDomainAssociations");

                entity.HasOne(d => d.FkViewNavigation)
                    .WithMany(p => p.ViewDataDomainAssociations)
                    .HasForeignKey(d => d.FkView)
                    .HasConstraintName("Views_ViewDataDomainAssociations");
            });

            modelBuilder.Entity<Views>(entity =>
            {
                entity.HasKey(e => e.PkView)
                    .HasName("Views_PK_View")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkView)
                    .HasName("Views_FK_View");

                entity.Property(e => e.PkView).HasColumnName("Pk_View");

                entity.Property(e => e.AssociateWithAllDataDomains)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Executable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FilterXml)
                    .IsRequired()
                    .HasColumnName("FilterXML")
                    .HasColumnType("xml");

                entity.Property(e => e.FkUserPersonalFor).HasColumnName("Fk_User_PersonalFor");

                entity.Property(e => e.FkView).HasColumnName("Fk_View");

                entity.Property(e => e.ForegroundColor).HasDefaultValueSql("((-16777216))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OrderXml)
                    .HasColumnName("OrderXML")
                    .HasColumnType("xml");

                entity.HasOne(d => d.FkUserPersonalForNavigation)
                    .WithMany(p => p.Views)
                    .HasForeignKey(d => d.FkUserPersonalFor)
                    .HasConstraintName("View_Users_PersonalFor");

                entity.HasOne(d => d.FkViewNavigation)
                    .WithMany(p => p.InverseFkViewNavigation)
                    .HasForeignKey(d => d.FkView)
                    .HasConstraintName("Views_Views");
            });

            modelBuilder.Entity<ViewUserSettings>(entity =>
            {
                entity.HasKey(e => e.PkViewUserSetting)
                    .HasName("ViewUserSettings_PK_ViewUserSetting")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkView)
                    .HasName("ViewUserSettings_FK_View");

                entity.HasIndex(e => new { e.FkUser, e.FkView })
                    .HasName("ViewUserSettings_FK_View_FK_User")
                    .IsUnique();

                entity.Property(e => e.PkViewUserSetting).HasColumnName("Pk_ViewUserSetting");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.FkView).HasColumnName("Fk_View");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.ViewUserSettings)
                    .HasForeignKey(d => d.FkUser)
                    .HasConstraintName("Users_ViewUserSettings");

                entity.HasOne(d => d.FkViewNavigation)
                    .WithMany(p => p.ViewUserSettings)
                    .HasForeignKey(d => d.FkView)
                    .HasConstraintName("Views_ViewUserSettings");
            });

            modelBuilder.Entity<Widgets>(entity =>
            {
                entity.HasKey(e => e.PkWidget)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.PkWidget).HasColumnName("Pk_Widget");

                entity.Property(e => e.Configuration).IsRequired();

                entity.Property(e => e.FkWidgetsConfiguration).HasColumnName("Fk_WidgetsConfiguration");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.FkWidgetsConfigurationNavigation)
                    .WithMany(p => p.Widgets)
                    .HasForeignKey(d => d.FkWidgetsConfiguration)
                    .HasConstraintName("DashboardConfigurations_Widgets");
            });

            modelBuilder.Entity<WorkspaceAssociations>(entity =>
            {
                entity.HasKey(e => e.PkWorkspaceAssociation)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkUser)
                    .HasName("WorkspaceAssociations_Fk_User");

                entity.HasIndex(e => e.FkUserGroup)
                    .HasName("WorkspaceAssociations_Fk_UserGroup");

                entity.HasIndex(e => e.FkWorkspace)
                    .HasName("WorkspaceAssociations_Fk_Workspace");

                entity.Property(e => e.PkWorkspaceAssociation).HasColumnName("Pk_WorkspaceAssociation");

                entity.Property(e => e.FkUser).HasColumnName("Fk_User");

                entity.Property(e => e.FkUserGroup).HasColumnName("Fk_UserGroup");

                entity.Property(e => e.FkWorkspace).HasColumnName("Fk_Workspace");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.WorkspaceAssociations)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Relation_1119");

                entity.HasOne(d => d.FkUserGroupNavigation)
                    .WithMany(p => p.WorkspaceAssociations)
                    .HasForeignKey(d => d.FkUserGroup)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Relation_1121");

                entity.HasOne(d => d.FkWorkspaceNavigation)
                    .WithMany(p => p.WorkspaceAssociations)
                    .HasForeignKey(d => d.FkWorkspace)
                    .HasConstraintName("Workspaces_WorkspaceAssociations");
            });

            modelBuilder.Entity<Workspaces>(entity =>
            {
                entity.HasKey(e => e.PkWorkspace)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.FkView)
                    .HasName("Workspaces_Fk_View");

                entity.Property(e => e.PkWorkspace).HasColumnName("Pk_Workspace");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.FkView).HasColumnName("Fk_View");

                entity.Property(e => e.LastRowUpdate).HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.FkViewNavigation)
                    .WithMany(p => p.Workspaces)
                    .HasForeignKey(d => d.FkView)
                    .HasConstraintName("Views_Workspaces");
            });
        }
    }
}

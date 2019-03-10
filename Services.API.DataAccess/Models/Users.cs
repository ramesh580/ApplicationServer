using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class Users
    {
        public Users()
        {
            ApprovalTemplateObligations = new HashSet<ApprovalTemplateObligations>();
            ApprovalWorkflowObligations = new HashSet<ApprovalWorkflowObligations>();
            ApprovalWorkflowsFkUserSetErroneousNavigation = new HashSet<ApprovalWorkflows>();
            ApprovalWorkflowsFkUserSetObsoleteNavigation = new HashSet<ApprovalWorkflows>();
            Comments = new HashSet<Comments>();
            FeatureSets = new HashSet<FeatureSets>();
            Features = new HashSet<Features>();
            FileReferences = new HashSet<FileReferences>();
            ImportSessions = new HashSet<ImportSessions>();
            MessageFolders = new HashSet<MessageFolders>();
            MessageForwardingRules = new HashSet<MessageForwardingRules>();
            MessageUserAssignements = new HashSet<MessageUserAssignements>();
            Messages = new HashSet<Messages>();
            NotificationForwardingRules = new HashSet<NotificationForwardingRules>();
            ObservationAlarmAcknowledgingObligations = new HashSet<ObservationAlarmAcknowledgingObligations>();
            ObservationAlarms = new HashSet<ObservationAlarms>();
            ObservationSpyingDefinitions = new HashSet<ObservationSpyingDefinitions>();
            Observations = new HashSet<Observations>();
            OutputFiles = new HashSet<OutputFiles>();
            PresentationTemplateBindings = new HashSet<PresentationTemplateBindings>();
            PresentationTemplates = new HashSet<PresentationTemplates>();
            Privileges = new HashSet<Privileges>();
            QueuedJobs = new HashSet<QueuedJobs>();
            SmartMessageFolders = new HashSet<SmartMessageFolders>();
            StoredExportDefinitions = new HashSet<StoredExportDefinitions>();
            StoredImportDefinitions = new HashSet<StoredImportDefinitions>();
            StoredJobDefinitions = new HashSet<StoredJobDefinitions>();
            StoredValidationConfigurations = new HashSet<StoredValidationConfigurations>();
            UserFavorites = new HashSet<UserFavorites>();
            UserGroupMemberships = new HashSet<UserGroupMemberships>();
            UserSessions = new HashSet<UserSessions>();
            ValidationRuns = new HashSet<ValidationRuns>();
            ViewUserSettings = new HashSet<ViewUserSettings>();
            Views = new HashSet<Views>();
            WorkspaceAssociations = new HashSet<WorkspaceAssociations>();
        }

        public int PkUser { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public byte Gender { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string Address { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTimeOffset? PasswordValidTill { get; set; }
        public bool Locked { get; set; }
        public bool? Active { get; set; }
        public bool PublishExtendedInformation { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTimeOffset LastModified { get; set; }
        public string PreNominalLetters { get; set; }
        public string PostNominalLetters { get; set; }
        public string Company { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public byte ApplicationServerLanguage { get; set; }
        public bool ManagerUser { get; set; }
        public int Culture { get; set; }
        public byte AuthenticationType { get; set; }
        public int? FkDataDomain { get; set; }
        public string Department { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual DashboardConfigurations DashboardConfigurations { get; set; }
        public virtual StaticTimespans StaticTimespans { get; set; }
        public virtual ICollection<ApprovalTemplateObligations> ApprovalTemplateObligations { get; set; }
        public virtual ICollection<ApprovalWorkflowObligations> ApprovalWorkflowObligations { get; set; }
        public virtual ICollection<ApprovalWorkflows> ApprovalWorkflowsFkUserSetErroneousNavigation { get; set; }
        public virtual ICollection<ApprovalWorkflows> ApprovalWorkflowsFkUserSetObsoleteNavigation { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<FeatureSets> FeatureSets { get; set; }
        public virtual ICollection<Features> Features { get; set; }
        public virtual ICollection<FileReferences> FileReferences { get; set; }
        public virtual ICollection<ImportSessions> ImportSessions { get; set; }
        public virtual ICollection<MessageFolders> MessageFolders { get; set; }
        public virtual ICollection<MessageForwardingRules> MessageForwardingRules { get; set; }
        public virtual ICollection<MessageUserAssignements> MessageUserAssignements { get; set; }
        public virtual ICollection<Messages> Messages { get; set; }
        public virtual ICollection<NotificationForwardingRules> NotificationForwardingRules { get; set; }
        public virtual ICollection<ObservationAlarmAcknowledgingObligations> ObservationAlarmAcknowledgingObligations { get; set; }
        public virtual ICollection<ObservationAlarms> ObservationAlarms { get; set; }
        public virtual ICollection<ObservationSpyingDefinitions> ObservationSpyingDefinitions { get; set; }
        public virtual ICollection<Observations> Observations { get; set; }
        public virtual ICollection<OutputFiles> OutputFiles { get; set; }
        public virtual ICollection<PresentationTemplateBindings> PresentationTemplateBindings { get; set; }
        public virtual ICollection<PresentationTemplates> PresentationTemplates { get; set; }
        public virtual ICollection<Privileges> Privileges { get; set; }
        public virtual ICollection<QueuedJobs> QueuedJobs { get; set; }
        public virtual ICollection<SmartMessageFolders> SmartMessageFolders { get; set; }
        public virtual ICollection<StoredExportDefinitions> StoredExportDefinitions { get; set; }
        public virtual ICollection<StoredImportDefinitions> StoredImportDefinitions { get; set; }
        public virtual ICollection<StoredJobDefinitions> StoredJobDefinitions { get; set; }
        public virtual ICollection<StoredValidationConfigurations> StoredValidationConfigurations { get; set; }
        public virtual ICollection<UserFavorites> UserFavorites { get; set; }
        public virtual ICollection<UserGroupMemberships> UserGroupMemberships { get; set; }
        public virtual ICollection<UserSessions> UserSessions { get; set; }
        public virtual ICollection<ValidationRuns> ValidationRuns { get; set; }
        public virtual ICollection<ViewUserSettings> ViewUserSettings { get; set; }
        public virtual ICollection<Views> Views { get; set; }
        public virtual ICollection<WorkspaceAssociations> WorkspaceAssociations { get; set; }
    }
}

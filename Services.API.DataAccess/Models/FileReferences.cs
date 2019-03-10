using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class FileReferences
    {
        public int PkFileReference { get; set; }
        public Guid FileReferenceGuid { get; set; }
        public long? FkBinaryPropertyValue { get; set; }
        public int? FkMessageAttachment { get; set; }
        public string OriginalFileName { get; set; }
        public long BinarySize { get; set; }
        public string MediaType { get; set; }
        public string Description { get; set; }
        public string Metadata { get; set; }
        public byte[] PreviewImage { get; set; }
        public string TextExtract { get; set; }
        public int? FkImportSessionFile { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public int? FkUserOwner { get; set; }
        public int? FkOutputFile { get; set; }
        public int? FkAttachement { get; set; }
        public long? FkReferencedImagePropertyValue { get; set; }
        public int? FkMapFileSet { get; set; }
        public int? FkStoredExportDefinitionTemplateFile { get; set; }
        public DateTimeOffset LastRowUpdate { get; set; }

        public virtual Attachements FkAttachementNavigation { get; set; }
        public virtual BinaryPropertyValues FkBinaryPropertyValueNavigation { get; set; }
        public virtual ImportedFiles FkImportSessionFileNavigation { get; set; }
        public virtual MapFileSets FkMapFileSetNavigation { get; set; }
        public virtual MessageAttachements FkMessageAttachmentNavigation { get; set; }
        public virtual OutputFiles FkOutputFileNavigation { get; set; }
        public virtual ReferencedImagePropertyValues FkReferencedImagePropertyValueNavigation { get; set; }
        public virtual StoredExportDefinitions FkStoredExportDefinitionTemplateFileNavigation { get; set; }
        public virtual Users FkUserOwnerNavigation { get; set; }
    }
}

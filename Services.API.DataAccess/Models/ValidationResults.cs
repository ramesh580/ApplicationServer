using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class ValidationResults
    {
        public ValidationResults()
        {
            InverseFkValidationResultParentNavigation = new HashSet<ValidationResults>();
        }

        public long PkValidationResult { get; set; }
        public long? FkValidationResultParent { get; set; }
        public int? FkValidationRun { get; set; }
        public byte SourceObjectType { get; set; }
        public long SourceObjectId { get; set; }
        public string SourceObjectName { get; set; }
        public byte SuccessStatus { get; set; }
        public string ValidationDetails { get; set; }

        public virtual ValidationResults FkValidationResultParentNavigation { get; set; }
        public virtual ValidationRuns FkValidationRunNavigation { get; set; }
        public virtual ICollection<ValidationResults> InverseFkValidationResultParentNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MessageForwardingRules
    {
        public int PkMessageForwardingRules { get; set; }
        public int? FkUser { get; set; }
        public byte SeverityFrom { get; set; }
        public byte SeverityTo { get; set; }
        public string RegularExpression { get; set; }
        public byte DeliveryMedium { get; set; }
        public string FilterExpression { get; set; }
        public byte FilterExpressionType { get; set; }
        public byte FilterExpressionScope { get; set; }
        public byte? MessageSourceContext { get; set; }
        public string Description { get; set; }

        public virtual Users FkUserNavigation { get; set; }
    }
}

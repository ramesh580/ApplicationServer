using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class GeneralTextTemplates
    {
        public int PkGeneralTextTemplate { get; set; }
        public short Type { get; set; }
        public byte Language { get; set; }
        public string Template { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MlTextTranslations
    {
        public int PkMlTextTranslation { get; set; }
        public int FkMlText { get; set; }
        public byte Language { get; set; }
        public string Text { get; set; }

        public virtual MlTexts FkMlTextNavigation { get; set; }
    }
}

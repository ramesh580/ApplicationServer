using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class MlTexts
    {
        public MlTexts()
        {
            MlTextTranslations = new HashSet<MlTextTranslations>();
        }

        public int PkMlText { get; set; }
        public Guid MlTextGuid { get; set; }

        public virtual ICollection<MlTextTranslations> MlTextTranslations { get; set; }
    }
}

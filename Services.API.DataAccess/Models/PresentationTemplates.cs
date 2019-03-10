using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class PresentationTemplates
    {
        public PresentationTemplates()
        {
            PresentationTemplateBindings = new HashSet<PresentationTemplateBindings>();
            UserFavorites = new HashSet<UserFavorites>();
        }

        public int PkPresentationTemplate { get; set; }
        public int FkDataDomain { get; set; }
        public int? FkUserPrivateFor { get; set; }
        public byte PresentationType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TemplateDefinition { get; set; }
        public string Path { get; set; }
        public string BindingDefinition { get; set; }

        public virtual DataDomains FkDataDomainNavigation { get; set; }
        public virtual Users FkUserPrivateForNavigation { get; set; }
        public virtual ICollection<PresentationTemplateBindings> PresentationTemplateBindings { get; set; }
        public virtual ICollection<UserFavorites> UserFavorites { get; set; }
    }
}

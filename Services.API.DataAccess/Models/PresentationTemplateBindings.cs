using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class PresentationTemplateBindings
    {
        public PresentationTemplateBindings()
        {
            UserFavorites = new HashSet<UserFavorites>();
        }

        public int PkPresentationTemplateBinding { get; set; }
        public int FkPresentationTemplate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BindingDefinition { get; set; }
        public int? FkUserPrivateFor { get; set; }

        public virtual PresentationTemplates FkPresentationTemplateNavigation { get; set; }
        public virtual Users FkUserPrivateForNavigation { get; set; }
        public virtual ICollection<UserFavorites> UserFavorites { get; set; }
    }
}

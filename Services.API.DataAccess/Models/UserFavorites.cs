using System;
using System.Collections.Generic;

namespace Services.API.DataAccess.Models
{
    public partial class UserFavorites
    {
        public int PkUserFavorite { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FkUser { get; set; }
        public int? FkView { get; set; }
        public int? FkPresentationTemplate { get; set; }
        public int? FkPresentationTemplateBinding { get; set; }

        public virtual PresentationTemplateBindings FkPresentationTemplateBindingNavigation { get; set; }
        public virtual PresentationTemplates FkPresentationTemplateNavigation { get; set; }
        public virtual Users FkUserNavigation { get; set; }
        public virtual Views FkViewNavigation { get; set; }
    }
}

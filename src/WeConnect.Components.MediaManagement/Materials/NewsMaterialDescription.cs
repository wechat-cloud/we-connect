using System.Collections.Generic;

namespace WeConnect.Components.MediaManagement
{
    public class NewsMaterialDescription
    {
        public NewsMaterialDescription()
        {
            Articles = new List<ArticleDescription>();
        }

        public IList<ArticleDescription> Articles { get; }
    }
}
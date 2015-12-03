using System.Collections.Generic;

namespace WeConnect.Components.MediaManagement
{
    public class NewsMaterialDescription
    {
        public NewsMaterialDescription()
        {
            Articles = new List<Article>();
        }

        public IList<Article> Articles { get; }
    }
}
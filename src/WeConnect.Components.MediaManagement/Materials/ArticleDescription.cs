using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeConnect.Components.MediaManagement
{
    public class ArticleDescription
    {
        public string Title { get; set; }
        public string ThumbMediaId { get; set; }
        public string Author { get; set; }
        public string Digest { get; set; }
        public string ShowCoverPic { get; set; }
        public string Content { get; set; }
        public string ContentSourceUrl { get; set; }
    }
}

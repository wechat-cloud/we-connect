using System.Collections.Generic;

namespace WeConnect.Components.Material
{
    public class NewsMaterialList
    {
        public int TotalCount { get; set; }
        public int ItemCount { get; set; }
        public IList<NewsMaterial> Item { get; set; }
    }
}
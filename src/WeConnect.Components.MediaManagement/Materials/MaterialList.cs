using System.Collections.Generic;

namespace WeConnect.Components.MediaManagement
{
    public class MaterialList
    {
        public MaterialList()
        {
            Item = new List<Material>();
        }

        public int TotalCount { get; set; }
        public int ItemCount { get; set; }
        public IList<Material> Item { get; set; }
    }
}
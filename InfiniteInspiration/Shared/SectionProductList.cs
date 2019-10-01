using System;
using System.Collections.Generic;
using System.Text;

namespace InfiniteInspiration.Shared
{
    public class SectionProductList : SectionItemBase
    {
        public List<SectionProduct> Products { get; set; }

        public SectionProductList()
        {
            Products = new List<SectionProduct>();
        }

    }
}

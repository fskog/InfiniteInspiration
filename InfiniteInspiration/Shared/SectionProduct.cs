using System;
using System.Collections.Generic;
using System.Text;

namespace InfiniteInspiration.Shared
{
    public class SectionProduct : SectionItemBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public SectionProduct(string name = "", string description = "", int price = 0)
        {
            SystemId = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
        }

        public SectionProduct()
        {
            SystemId = Guid.NewGuid();
        }
    }
}

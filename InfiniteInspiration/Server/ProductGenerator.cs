using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfiniteInspiration.Shared;

namespace InfiniteInspiration.Server
{
    public class ProductGenerator
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] ProductType = new[]
{
            "Table", "Chair", "Lamp", "Sideboard", "Dresser", "Wardrobe", "Glass", "Knife", "Basket", "Box"
        };

        private static readonly string[] DescriptionText = new[] 
        {
            "5-tier ladder-style bookcase for placing keepsakes, decor, books, awards, and more",
            "Descending design with shelf widths widening at the bottom",
            "Straight back allows you to place bookcase neatly against a wall; angled front saves space",
            "Solid rubber wood construction; each shelf holds 25 pounds",
            "Minimal, modern design complements a variety of interior aesthetics",
            "Easy to assemble with provided instructions and hardware"
    };

        public SectionProduct GenerateProduct()
        {
            var rng = new Random();
            return new SectionProduct
            {
                Name = $"{Summaries[rng.Next(Summaries.Length)]} {ProductType[rng.Next(ProductType.Length)]}",
                Description = $"{DescriptionText[rng.Next(DescriptionText.Length)]}",
                Price = rng.Next(5, 120) * 10 - 1,
                SystemId = Guid.NewGuid()
            };
        }

    }
}

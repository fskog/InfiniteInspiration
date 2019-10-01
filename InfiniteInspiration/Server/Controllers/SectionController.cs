using InfiniteInspiration.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InfiniteInspiration.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SectionController : ControllerBase
    {

        private int postNumber;
        private readonly ILogger<SectionController> logger;

        public SectionController(ILogger<SectionController> logger)
        {
            this.logger = logger;
            postNumber = 1;
        }


        [HttpGet]
        public SectionItemBase GetArticle()
        {
            HttpClient Http = new HttpClient();
            var result = Http.GetAsync($"https://jsonplaceholder.typicode.com/posts/{postNumber}").Result;
            string stringData = result.Content.ReadAsStringAsync().Result;
            var article = JsonSerializer.Deserialize<ArticleItem>(stringData);
            postNumber++;
            return new SectionItemBase() { SystemId = Guid.NewGuid(), Title = article.title, Text = article.body };
        }

        [HttpGet]
        [Route("GetProductList")]
        public SectionProductList GetProductList()
        {
            var productGenerator = new ProductGenerator();
            var productList = new SectionProductList();
            productList.SystemId = Guid.NewGuid();
            productList.Title = "Products";
            productList.Text = "Here are some products you may be interested in.";
            foreach (var i in Enumerable.Range(1, 4))
            {
                productList.Products.Add(productGenerator.GenerateProduct());
            }
            return productList;
        }

    }
    class ArticleItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public int userid { get; set; }
    }
}

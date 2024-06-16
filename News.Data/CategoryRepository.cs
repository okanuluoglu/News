using News.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace News.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly HttpClient _httpClient;
        private const string ListJsonUrl = "https://www.turkmedya.com.tr/anasayfa.json";

        public CategoryRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Kategorileri içeren bir json dosyamız olmadığından. Haberleri JSON dosyalarından çeker haberlerin içerisinden kategorileri alır 
        /// </summary>
        /// <returns>Haber kategorilerini döner.</returns>
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            var response = await _httpClient.GetStringAsync(ListJsonUrl);
            var root = JsonConvert.DeserializeObject<Entities.News>(response);
            var categories = root.Data
                .SelectMany(d => d.NewsItemList)
                .Select(i => i.Category)
                .Distinct()
                .ToList();
            return categories;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.Data.Entities;

namespace News.Data
{
    public class NewsRepository : INewsRepository
    {
        private readonly HttpClient _httpClient;
        private const string HomePageUrl = "https://www.turkmedya.com.tr/anasayfa.json";
        private const string DetailUrl = "https://www.turkmedya.com.tr/detay.json";

        public NewsRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Haberleri JSON dosyalarından çeker, haber kategorisi ve anahtar kelimeye göre filtreler
        /// </summary>
        /// <param name="category">Haber kategorisi dolu gönderilirse haber kategorisine göre filtreleme yapar</param>
        /// <param name="keyword">Anahtar Kelime dolu gönderilirse anahtar kelimeye göre filtreleme yapar</param>
        /// <returns>Haberlerleri döner</returns>
        public async Task<IEnumerable<NewsItem>> GetAllAsync(string category, string keyword)
        {
            var response = await _httpClient.GetStringAsync(HomePageUrl);
            var root = JsonConvert.DeserializeObject<Entities.News>(response);
            var newsItems = root.Data.SelectMany(d => d.NewsItemList);

            if (!string.IsNullOrEmpty(category))
            {
                newsItems = newsItems.Where(n => n.Category.CategoryId.Equals(category, System.StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                newsItems = newsItems.Where(n => n.Title.Contains(keyword, System.StringComparison.OrdinalIgnoreCase));
            }

            return newsItems;
        }

        /// <summary>
        /// Haberler detayını JSON dosyalarından çeker
        /// </summary>
        /// <returns>Haber detayını ve ilgili habeleri içeren veriyi döner</returns>
        public async Task<NewsDetailData> GetNewsDetail()
        {
            var response = await _httpClient.GetStringAsync(DetailUrl);
            var newsDetail = JsonConvert.DeserializeObject<NewsDetailRoot>(response);
            return newsDetail.Data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.Data;
using News.Data.Entities;

namespace News.Service
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;

        public NewsService(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        /// <summary>
        /// Haberleri JSON dosyalarından çeker, haber kategorisi ve anahtar kelimeye göre filtreler
        /// </summary>
        /// <param name="category">Haber kategorisi dolu gönderilirse haber kategorisine göre filtreleme yapar</param>
        /// <param name="keyword">Anahtar Kelime dolu gönderilirse anahtar kelimeye göre filtreleme yapar</param>
        /// <returns>Haberlerleri döner</returns>
        public async Task<PagedResult<NewsItem>> GetAllNewsAsync(int pageNumber, int pageSize, string category, string keyword)
        {
            var allNews = await _newsRepository.GetAllAsync(category, keyword);
            var filteredNews = allNews.ToList();

            var totalCount = filteredNews.Count();
            var totalPages = (int)System.Math.Ceiling(totalCount / (double)pageSize);

            var items = filteredNews
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedResult<NewsItem>
            {
                Items = items,
                CurrentPage = pageNumber,
                TotalPages = totalPages,
                PageSize = pageSize,
                TotalCount = totalCount
            };
        }

        /// <summary>
        /// Haberler detayını JSON dosyalarından çeker
        /// </summary>
        /// <returns>Haber detayını ve ilgili habeleri içeren veriyi döner</returns>
        public async Task<NewsDetailData> GetNewsDetailAsync()
        {
            return await _newsRepository.GetNewsDetail();
        }
    }
}

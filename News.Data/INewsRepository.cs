using News.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data
{
    public interface INewsRepository
    {
        /// <summary>
        /// Haberleri JSON dosyalarından çeker, haber kategorisi ve anahtar kelimeye göre filtreler
        /// </summary>
        /// <param name="category">Haber kategorisi dolu gönderilirse haber kategorisine göre filtreleme yapar</param>
        /// <param name="keyword">Anahtar Kelime dolu gönderilirse anahtar kelimeye göre filtreleme yapar</param>
        /// <returns>Haberlerleri döner</returns>
        Task<IEnumerable<NewsItem>> GetAllAsync(string category, string keyword);
        /// <summary>
        /// Haberler detayını JSON dosyalarından çeker
        /// </summary>
        /// <returns>Haber detayını ve ilgili habeleri içeren veriyi döner</returns>
        Task<NewsDetailData> GetNewsDetail();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.Data.Entities;

namespace News.Data
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Kategorileri içeren bir json dosyamız olmadığından. Haberleri JSON dosyalarından çeker haberlerin içerisinden kategorileri alır 
        /// </summary>
        /// <returns>Haber kategorilerini döner.</returns>
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}

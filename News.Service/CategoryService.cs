using News.Data.Entities;
using News.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        /// <summary>
        /// Kategorileri içeren bir json dosyamız olmadığından. Haberleri JSON dosyalarından çeker haberlerin içerisinden kategorileri alır 
        /// </summary>
        /// <returns>Haber kategorilerini döner.</returns>
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllCategoriesAsync();
        }
    }
}

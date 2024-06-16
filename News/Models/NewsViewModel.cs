using News.Data.Entities;
using News.Data;

namespace News.Web.Models
{
    public class NewsViewModel
    {
        public NewsViewModel()
        {
            Categories = new List<Category>();
        }
        public PagedResult<NewsItem> PagedNews { get; set; } = new();
        public string SelectedCategoryId { get; set; }
        public string Keyword { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}

using News.Data.Entities;

namespace News.Web.Models
{
    public class NewsDetailViewModel
    {
        public string Title { get; set; }
        public string BodyText { get; set; }
        public string ImageUrl { get; set; }
        public RelatedNews RelatedNews { get; set; }


    }
}

using Microsoft.AspNetCore.Mvc;
using News.Web.Models;
using News.Service;
using News.Web.Models;
using System.Diagnostics;

namespace News.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsService _newsService;
        private readonly ICategoryService _categoryService;


        public HomeController(ILogger<HomeController> logger, INewsService newsService, ICategoryService categoryService)
        {
            _logger = logger;
            _newsService = newsService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 5, string category = "", string keyword = "")
        {
            var pagedNews = await _newsService.GetAllNewsAsync(pageNumber, pageSize, category, keyword);
            var categories = await _categoryService.GetAllCategoriesAsync();

            var viewModel = new NewsViewModel
            {
                PagedNews = pagedNews,
                SelectedCategoryId = category,
                Keyword = keyword,
                Categories = categories
            };
            return View(viewModel);
        }

        public async Task<IActionResult> Detail()
        {
            var newsDetailData = await _newsService.GetNewsDetailAsync();
            
            var viewModel = new NewsDetailViewModel
            {
                BodyText = newsDetailData.NewsDetail.BodyText,
                Title = newsDetailData.NewsDetail.Title,
                ImageUrl = newsDetailData.NewsDetail.ImageUrl,
                RelatedNews = newsDetailData.RelatedNews

            };
            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

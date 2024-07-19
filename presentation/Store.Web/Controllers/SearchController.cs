using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {

        private readonly KakiService kakiService;

        public SearchController(KakiService kakiService)
        {
            this.kakiService = kakiService;
        }
    
        public IActionResult Index(string query)
        {
            var kakis = kakiService.GetAllByQuery(query);

            return View(kakis);
        }
    }
}

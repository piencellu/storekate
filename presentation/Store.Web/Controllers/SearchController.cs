using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IKakiRepository kakiRepository;

        public SearchController(IKakiRepository kakiRepository)
        {
            this.kakiRepository = kakiRepository;
        }
    
        public IActionResult Index(string query)
        {
            var kakis = kakiRepository.GetAllByTitle(query);

            return View(kakis);
        }
    }
}

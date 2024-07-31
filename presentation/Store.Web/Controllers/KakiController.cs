using Microsoft.AspNetCore.Mvc;
using Store.Memory;

namespace Store.Web.Controllers
{
    public class KakiController : Controller
    {
        private readonly IKakiRepository _kakiRepository;

        public KakiController(IKakiRepository kakiRepository) 
        {
            _kakiRepository = kakiRepository;
        }
        public IActionResult Index(int id)
        {
            Kaki kaki = _kakiRepository.GetById(id);

            return View(kaki);
        }
    }
}

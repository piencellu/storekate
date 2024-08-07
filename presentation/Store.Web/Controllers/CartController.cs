using Microsoft.AspNetCore.Mvc;
using Store.Web.Models;

namespace Store.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IKakiRepository _kakiRepository;

        public CartController(IKakiRepository kakiRepository) 
        {
            _kakiRepository = kakiRepository;
        }
        public IActionResult Add(int id)
        {
            var kaki = _kakiRepository.GetById(id);
            Cart cart;
            if (!HttpContext.Session.TryGetCart(out cart))
                cart = new Cart();

            if (cart.Items.ContainsKey(id))
                cart.Items[id]++;
            else
                cart.Items[id] = 1;

            cart.Amount += kaki.Price;

            HttpContext.Session.Set(cart);


            return RedirectToAction("Index", "Kaki", new { id });
        }
    }
}

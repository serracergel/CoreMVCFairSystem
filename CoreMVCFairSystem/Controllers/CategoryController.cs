using Microsoft.AspNetCore.Mvc;

namespace CoreMVCFairSystem.Controllers
{
    //ToDo:categorypagevm,DTO ile Kategoriler listelenicek kullanici ya olan kategoriden secicek ya da kendisi bir kategori ve aciklamasi seklinde eklicek.Ilgili validation ayarlamalari RequestModel'da yapilicak
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

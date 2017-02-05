using GoblinPF.Models;
using GoblinPF.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GoblinPF.Controllers
{
    public class HomeController : Controller
    {
        private CategoryDAO _cdao;

        public HomeController(CategoryDAO cdao)
        {
            _cdao = cdao;
        }

        public IActionResult Index() 
        {
            var model = new IndexViewModel {
                Categories = _cdao.GetAll()
            };

            return View(model);
        }
    }
}
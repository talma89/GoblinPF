using GoblinPF.Entities;
using GoblinPF.Models;
using GoblinPF.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GoblinPF.Controllers
{
    public class HomeController : Controller
    {
        private CategoryDAO _cdao;
        private TransactionDAO _tdao;

        public HomeController(CategoryDAO cdao, TransactionDAO tdao)
        {
            _cdao = cdao;
            _tdao = tdao;
        }

        [HttpGet]
        public IActionResult Index() 
        {
            var model = new IndexViewModel();
            model.Categories = _cdao.GetCategorySelectors();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            Transaction trans = new Transaction();
            trans.Category = _cdao.Get(model.CategoryId);
            trans.Cost = model.Cost;
            _tdao.Add(trans);

            model.TransactionMade = true;
            model.Categories = _cdao.GetCategorySelectors();

            return View(model);
        }
    }
}
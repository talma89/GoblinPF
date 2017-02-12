using System.Collections.Generic;
using System.Linq;
using GoblinPF.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoblinPF.Models
{
    public class CategoryDAO
    {
        private GoblinPFDBContext _context;

        public CategoryDAO(GoblinPFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }

        public Category Get(int id)
        {
            return _context.Categories.FirstOrDefault(r => r.Id == id);
        }



        public List<SelectListItem> GetCategorySelectors()
        {
            var catSelect = new List<SelectListItem>();
            foreach(var category in GetAll())
            {
                catSelect.Add(new SelectListItem {
                    Text = category.Name,
                    Value = category.Id.ToString()
                });
            }

            return catSelect;
        }
    }
}
using System.Collections.Generic;
using GoblinPF.Entities;

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
    }
}
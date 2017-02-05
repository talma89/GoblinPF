using System.Collections.Generic;
using GoblinPF.Entities;

namespace GoblinPF.ViewModels
{
    public class IndexViewModel
    {
        public double Cost { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
using System.Collections.Generic;
using GoblinPF.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoblinPF.ViewModels
{
    public class IndexViewModel
    {
        private CategoryDAO _cdao;

        public double Cost { get; set; }
        public int CategoryId { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public bool TransactionMade { get; set; }
    }
}
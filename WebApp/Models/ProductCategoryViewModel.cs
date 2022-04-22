using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.Catalog.Categories;
using ViewModels.Catalog.Product;
using ViewModels.Common;

namespace WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<ProductViewModel> Products { get; set; }
    }
}
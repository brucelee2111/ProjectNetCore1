using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.Catalog.Categories;
using ViewModels.Catalog.Product;
using ViewModels.Catalog.ProductImages;

namespace WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductViewModel Product { get; set; }

        public List<ProductViewModel> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}
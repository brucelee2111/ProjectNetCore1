
using Application.Catalog.Products.Dtos;
using Application.Catalog.Products.Dtos.Public;
using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}

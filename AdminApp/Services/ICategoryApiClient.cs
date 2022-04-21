using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.Catalog.Categories;

namespace AdminApp.Services
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);
    }
}
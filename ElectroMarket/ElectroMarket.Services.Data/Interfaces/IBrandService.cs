using ElektroMarket.Web.ViewModels.Brand;
using ElektroMarket.Web.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMarket.Services.Data.Interfaces
{
    public interface IBrandService
    {
        Task<IEnumerable<SelectBrandFormModel>> GetAllBrandsAsync();

    }
}

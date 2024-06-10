using ElectroMarket.Data;
using ElectroMarket.Services.Data.Interfaces;
using ElektroMarket.Web.ViewModels.Category;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMarket.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly ElectroMarketDbContext dbContext;

        public CategoryService(ElectroMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<SelectCategoryFormModel>> GetAllCategoriesAsync()
        {
            var categories = await this.dbContext.Categories
                 .AsNoTracking()
                 .Select(c => new SelectCategoryFormModel
                 {
                     Id = c.Id,
                     Name = c.Name,
                 })
                 .ToListAsync();

            return categories;
        }
    }
}

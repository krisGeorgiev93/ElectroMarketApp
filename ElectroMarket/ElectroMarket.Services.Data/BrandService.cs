using ElectroMarket.Data;
using ElectroMarket.Services.Data.Interfaces;
using ElektroMarket.Web.ViewModels.Brand;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMarket.Services.Data
{
    public class BrandService : IBrandService
    {
        private readonly ElectroMarketDbContext dbContext;

        public BrandService(ElectroMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<SelectBrandFormModel>> GetAllBrandsAsync()
        {
            var brands = await this.dbContext.Brands
                .AsNoTracking()
                .Select(b=> new SelectBrandFormModel 
                { 
                    Id = b.Id,
                    Name = b.Name,
                })
                .ToListAsync();
            return brands;
        }
    }
}

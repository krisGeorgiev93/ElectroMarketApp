using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ElectroMarket.Data
{
    public class ElectroMarketDbContext : IdentityDbContext
    {
        public ElectroMarketDbContext(DbContextOptions<ElectroMarketDbContext> options)
            : base(options)
        {
        }
    }
}

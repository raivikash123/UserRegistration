using FirstApi.Data;
using FirstApi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FirstApi.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly FirstApiDbContext firstApiDbContext;

        public RegionRepository(FirstApiDbContext firstApiDbContext)
        {
            this.firstApiDbContext = firstApiDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await firstApiDbContext.Regions.ToListAsync();
        }
    }
}

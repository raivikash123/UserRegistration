using FirstApi.Models.Domain;

namespace FirstApi.Repositories
{
    public interface IRegionRepository
    {
       Task<IEnumerable<Region>> GetAllAsync();
    }
}

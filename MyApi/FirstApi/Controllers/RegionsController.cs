using AutoMapper;
using FirstApi.Models.Domain;
using FirstApi.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace FirstApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository,IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

      

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            // var regions = new List<Region>()
            // {
            // new Region
            //{
            //  Id=Guid.NewGuid(),
            //Name="Wellington",
            //Code="WLG",
            //Area=227564,
            //Lat=-1.24356,
            //Long=299.98,
            //Population=98765435678
            //},
            //new Region
            //{
            //  Id=Guid.NewGuid(),
            //Name="Auckland",
            //Code="AUCK",
            //Area=227564,
            //Lat=-1.24356,
            //Long=299.98,
            //Population=98765435678
            //}
            //};
            var regions = await regionRepository.GetAllAsync();
            //return DTO Regions
            //var regionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population,
            //    };
            //    regionsDTO.Add(regionDTO);
            //});
            var regionsDTO=mapper.Map<List<Models.DTO.Region>>(regions);
            return Ok(regionsDTO);
        }
    }
}

using AutoMapper;

namespace FirstApi.Profiles
{
    public class RegionsProfile:Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region,Models.DTO.Region>()
                .ReverseMap();
        }
    }
}

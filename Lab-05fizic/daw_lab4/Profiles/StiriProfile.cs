using AutoMapper;
using daw_lab4.Models;

namespace daw_lab4.Profiles
{
    public class StiriProfile: Profile
    {
        public StiriProfile()
        {
            CreateMap<GetStireDto, Stire>();
            CreateMap<Stire, GetStireDto>();
            CreateMap<PostStireDto, Stire>();
            CreateMap<Stire, PostStireDto>();
        }
    }
}

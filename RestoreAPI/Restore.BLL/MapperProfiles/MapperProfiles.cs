using AutoMapper;
using Restore.BLL.Dtos;
using Restore.DLL.Entities;

namespace Restore.BLL.MapperProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}

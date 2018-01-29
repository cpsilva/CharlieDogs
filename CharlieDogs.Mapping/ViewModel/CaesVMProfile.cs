using AutoMapper;
using CharlieDogs.DataAccess.Database.Entites;
using CharlieDogs.Domain.ViewModel;

namespace CharlieDogs.Mapping.ViewModel
{
    public class CaesVMProfile : Profile
    {
        public CaesVMProfile()
        {
            CreateMap<CaesVM, CachorrosEntity>();

            CreateMap<CaesVM, ImagensEntity>();

            CreateMap<CaesVM, RacaEntity>();
        }
    }
}

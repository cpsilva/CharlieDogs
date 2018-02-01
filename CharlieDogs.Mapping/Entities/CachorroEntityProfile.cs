using AutoMapper;
using CharlieDogs.DataAccess.Database.Entites;
using CharlieDogs.Domain.Enums;
using CharlieDogs.Domain.ViewModel;

namespace CharlieDogs.Mapping.Entities
{
    public class CachorroEntityProfile : Profile
    {
        public CachorroEntityProfile()
        {
            CreateMap<CachorrosEntity, CaesVM>()
                .ForMember(dest => dest.Porte, opt => opt.MapFrom(src => (EnumTipoPorte)src.Porte))
                .ForMember(dest => dest.CorPredominante, opt => opt.MapFrom(src => (EnumCorPredominante)src.CorPredominante))
                .ForMember(dest => dest.RacaDescricao, opt => opt.MapFrom(src => src.Raca.Descricao))
                .ForMember(dest => dest.Imagem, opt => opt.MapFrom(src => src.Imagens.Imagem));
        }
    }
}

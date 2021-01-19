using AutoMapper;
using LFERP.App.ViewModels.Cadastro.Logradouro;
using LFERP.Negocio.Modelo.Cadastro.Logradouro;

namespace LFERP.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Pais, PaisViewModel>().ReverseMap();
            
            
            
        }
    }
}

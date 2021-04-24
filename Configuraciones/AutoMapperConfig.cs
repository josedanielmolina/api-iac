namespace Configuraciones
{
    using AutoMapper;

    using Modelos;
    using Dto;
    using System;

    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<TblPruebaVisual, PruebaVisualDto>()
                .ForMember(x => x.Firma, opt => opt.Ignore());


            CreateMap<PruebaVisualDto, TblPruebaVisual>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.Firma, opt => opt.Ignore());

            CreateMap<TblListaMaestra, ListaMaestraDto>();

        }



    }
}

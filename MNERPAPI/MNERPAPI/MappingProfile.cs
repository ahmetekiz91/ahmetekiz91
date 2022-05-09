using AutoMapper;
using DBModel.DTO;
using DBModel.Model;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNERPAPI
{
    public static class ConfigureMappingExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

            IMapper mapper = mappingConfig.CreateMapper();

            service.AddSingleton(mapper);

            return service;
        }
    }
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            AllowNullCollections = true;

            //CreateMap<AttributeValuesDTO, ATTRIBUTESVALUE>();
            //CreateMap<ATTRIBUTESVALUE, AttributeValuesDTO>();
            CreateMap<AttributeValuesDTO, ATTRIBUTESVALUE>().ForMember(vm => vm.ACTIVE, m => m.MapFrom(x => (x.ACTIVE == true ? 1 : 0))).ForMember(vm=>vm.BIRIM_ID,m=>m.MapFrom(m=>m.BIRIM_ID));
            CreateMap<ATTRIBUTESVALUE, AttributeValuesDTO>().ForMember(vm => vm.ACTIVE, m => m.MapFrom(x => (x.ACTIVE == 1 ? true : false))).ForMember(vm => vm.BIRIM_ID, m => m.MapFrom(m => m.BIRIM_ID));
            CreateMap<CARIKARTDTO, DBModel.Model.CARIKART>().ForMember(vm => vm.ACTIVE, m => m.MapFrom(x => (x.ACTIVE == true ? 1 : 0))).ForMember(vm => vm.ALICI, m => m.MapFrom(x => (x.ALICI == true ? 1 : 0))).ForMember(vm => vm.SATICI, m => m.MapFrom(x => (x.SATICI == true ? 1 : 0)));
            CreateMap<DBModel.Model.CARIKART, CARIKARTDTO>().ForMember(vm => vm.ACTIVE, m => m.MapFrom(x => (x.ACTIVE == 1 ? true : false))).ForMember(vm => vm.ALICI, m => m.MapFrom(x => (x.ALICI == 1 ? true : false))).ForMember(vm => vm.SATICI, m => m.MapFrom(x => (x.SATICI == 1 ? true : false)))
                ;

        }
    }
}



using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNERP.Server.Extension
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

            //CreateMap<DepoViewModel, Depolar>();
            //CreateMap<Depolar, DepoViewModel>();
            //CreateMap<KasaViewModel, Kasalar>();
            //CreateMap<Kasalar, KasaViewModel>();

            //CreateMap<MalzemeViewModel, Malzeme>().ForMember(vm => vm.SONURUN, m => m.MapFrom(x => (x.SONURUN == true ? 1 : 0)))
            //.ForMember(vm => vm.YMAMUL, m => m.MapFrom(x => (x.YMAMUL == true ? 1 : 0)))
            //.ForMember(vm => vm.SARF, m => m.MapFrom(x => (x.SARF == true ? 1 : 0)))
            //.ForMember(vm => vm.Alis_Grubumu, m => m.MapFrom(x => (x.Alis_Grubumu == true ? 1 : 0)))
            //.ForMember(vm => vm.Satis_Grubumu, m => m.MapFrom(x => (x.Satis_Grubumu == true ? 1 : 0)));

            // CreateMap<Malzeme, MalzemeViewModel>()
            //.ForMember(vm => vm.SONURUN, m => m.MapFrom(x => (x.SONURUN == 1 ? true : false)))
            //.ForMember(vm => vm.YMAMUL, m => m.MapFrom(x => (x.YMAMUL == 1 ? true : false)))
            //.ForMember(vm => vm.SARF, m => m.MapFrom(x => (x.SARF == 1 ? true : false)))
            //.ForMember(vm => vm.Alis_Grubumu, m => m.MapFrom(x => (x.Alis_Grubumu == 1 ? true : false)))
            //.ForMember(vm => vm.Satis_Grubumu, m => m.MapFrom(x => (x.Satis_Grubumu == 1 ? true : false)));

        }
    }
}

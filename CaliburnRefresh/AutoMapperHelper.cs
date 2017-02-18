using AutoMapper;
using CaliburnRefresh.Models;
using CaliburnRefresh.ViewModels;


namespace CaliburnRefresh
{
    public static class AutoMapperHelper
    {
        

        public static IMapper DoMappings()
        {
            AutoMapper.MapperConfiguration Config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<HeaderModel, HeaderNumberOneViewModel>();
                cfg.CreateMap<HeaderModel, HeaderNumberTwoViewModel>();
                cfg.CreateMap<HeaderModel, BodyViewModel>();

                cfg.CreateMap<HeaderBaseViewModel, HeaderModel>();
                cfg.CreateMap<BodyViewModel, HeaderModel>();




            });


            IMapper mapper = Config.CreateMapper();

            return mapper;


        }


    }
}

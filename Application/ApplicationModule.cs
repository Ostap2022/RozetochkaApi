
using Application.Services.Users;
using Autofac;
using AutoMapper;

namespace Application
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var mapper = LoadMappers(builder);

            LoadServices(builder, mapper);

            base.Load(builder);
        }
        private void LoadServices(ContainerBuilder builder, IMapper mapper)
        {
            _ = builder
                .RegisterType<UserService>()
                .As<IUserService>()
                .InstancePerLifetimeScope()
                .WithProperty("Mapper", mapper);
            
        }

        private IMapper LoadMappers(ContainerBuilder builder)
        {
            var config = new MapperConfiguration(cfg =>
            {
                var profiles = AppDomain
                             .CurrentDomain
                             .GetAssemblies();
                cfg.AddMaps(profiles);
            });
            var mapper = config.CreateMapper();
            builder.RegisterInstance(mapper).SingleInstance();
            return mapper;
        }






    }
}

using Autofac;
using Persistense.DAL.Entities;

namespace Persistense.DAL
{
    public class DalModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<RozetochkaDbContext>()
                .InstancePerLifetimeScope();

            builder
                .RegisterType<Repository<Product>>()
                .As<IRepository<Product>>()
                .InstancePerLifetimeScope();

            base.Load(builder);
    }   }
}

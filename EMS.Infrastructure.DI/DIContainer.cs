using EMS.Infrastructure.DI.Registries;
using StructureMap;

namespace EMS.Infrastructure.DI
{
    public static class DIContainer
    {
        public static IContainer Prepare()
        {
            var container = new Container();

            container.Configure(config =>
            {
                config.AddRegistry<RepositoryRegistry>();
                config.AddRegistry<DataRegistry>();
            });

            return container;
        }
    }
}

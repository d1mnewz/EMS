using StructureMap;

namespace EMS.Infrastructure.DI.Registries
{
    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            
            Scan(x =>
                {
                    x.AssembliesFromApplicationBaseDirectory();
                    x.WithDefaultConventions();
                }
            );
        }
    }
}

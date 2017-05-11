using System;
using System.Collections.Generic;
using System.Text;
using StructureMap;

namespace EMS.Infrastructure.DI.Registries
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(x =>
            {
                x.AssembliesFromApplicationBaseDirectory();
                x.WithDefaultConventions();
            });
        }
    }
}
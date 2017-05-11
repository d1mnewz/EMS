﻿using EMS.Core.Infrastructure.Db;
using StructureMap;

namespace EMS.Infrastructure.DI.Registries
{
    public class DataRegistry : Registry
    {
        public DataRegistry()
        {
            Scan(x =>
            {
                x.AssembliesFromApplicationBaseDirectory();
                x.AddAllTypesOf<ISeed>();
            });
        }
    }
}
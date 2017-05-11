﻿using Microsoft.EntityFrameworkCore;

namespace EMS.Web.Core.Data.Extensions
{
    public static class DbSetExtensions
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}

﻿using CoralTime.DAL.Models;
using Microsoft.Extensions.Caching.Memory;
using System.Linq;

namespace CoralTime.DAL.Repositories
{
    public class ReportsSettingsRepository : _BaseRepository<ReportsSettings>
    {
        public ReportsSettingsRepository(AppDbContext context, IMemoryCache memoryCache, string userId)
            : base(context, memoryCache, userId) { }

        public override ReportsSettings LinkedCacheGetById(int id)
        {
            return GetQueryWithIncludes().FirstOrDefault(x => x.Id == id);
        }
    }
}

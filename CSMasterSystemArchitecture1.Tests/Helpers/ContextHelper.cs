using CSMasterSystemArchitecture1.Context;
using CSMasterSystemArchitecture1.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMasterSystemArchitecture1.Tests.Helpers
{
    internal class ContextHelper
    {
        public static ItemDbContext InitializeContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<ItemDbContext>()
            .UseInMemoryDatabase(databaseName: dbName)
            .Options;

            ItemDbContext context = new ItemDbContext(options);
            context.Database.EnsureDeleted();

            return context;
        }
    }
}

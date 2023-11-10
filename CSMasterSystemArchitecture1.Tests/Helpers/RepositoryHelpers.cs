using CSMasterSystemArchitecture1.Context;
using CSMasterSystemArchitecture1.Repositories;
using Microsoft.EntityFrameworkCore;
using NuGet.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMasterSystemArchitecture1.Tests.Helpers
{
    internal class RepositoryHelpers
    {
        public static ItemRepository InitializeRepository()
        {
            ItemDbContext context = ContextHelper.InitializeContext("db");
            ItemRepository repository = new ItemRepository(context);

            return repository;
        }
    }
}

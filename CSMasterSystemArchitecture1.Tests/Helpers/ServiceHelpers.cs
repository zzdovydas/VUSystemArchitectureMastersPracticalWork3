using CSMasterSystemArchitecture1.Context;
using CSMasterSystemArchitecture1.Repositories;
using CSMasterSystemArchitecture1.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMasterSystemArchitecture1.Tests.Helpers
{
    public static class ServiceHelpers
    {
        public static ItemService InitializeService()
        {
            ItemRepository repository = RepositoryHelpers.InitializeRepository();
            ItemService service = new(repository);

            return service;
        }
    }
}

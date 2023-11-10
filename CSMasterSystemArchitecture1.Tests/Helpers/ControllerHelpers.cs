using Microsoft.AspNetCore.Mvc;
using CSMasterSystemArchitecture1.Controllers;
using CSMasterSystemArchitecture1.Models;
using CSMasterSystemArchitecture1.Services;
using Microsoft.EntityFrameworkCore;
using CSMasterSystemArchitecture1.Context;
using CSMasterSystemArchitecture1.Repositories;

namespace CSMasterSystemArchitecture1.Tests.Helpers
{
    public static class ControllerHelpers
    {
        public static ItemController InitializeController()
        {
            ItemRepository repository = RepositoryHelpers.InitializeRepository();
            ItemService service = new(repository);
            ItemController controller = new(service);

            return controller;
        }
    }
}

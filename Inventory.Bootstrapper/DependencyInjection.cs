using Domain_Inventory.Infra;
using Infra_Inventory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bootstrapper_Inventory
{
    public static class DependencyInjection
    {
        public static void SetUpDependencies(IServiceCollection services)
        {
            SetUpInfra(services);
            SetUpBusiness(services);
        }

        private static void SetUpInfra(IServiceCollection services) 
        {
            services.AddSingleton<IItemRepo, Item_InMemoryRepo>();
            services.AddSingleton<IMovementRepo, Movement_InMemoryRepo>();
        }

        private static void SetUpBusiness(IServiceCollection services) { }
    }
}

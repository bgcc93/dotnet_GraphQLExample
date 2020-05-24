using GraphQL;
using System;
using GraphQL.Types;
using GraphQL.Utilities;
using API_Inventory.GraphQL.Queries;
using Inventory.API.GraphQL.Mutations;

namespace API_Inventory.GraphQL
{
    public class InventorySchema : Schema
    {
        public InventorySchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<InventoryQuery>();
            Mutation = provider.GetRequiredService<InventoryMutation>();
        }
    }
}

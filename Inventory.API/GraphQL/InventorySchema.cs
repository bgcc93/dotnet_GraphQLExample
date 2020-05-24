using GraphQL;
using System;
using GraphQL.Types;
using GraphQL.Utilities;
using API_Inventory.GraphQL.Queries;

namespace API_Inventory.GraphQL
{
    public class InventorySchema : Schema
    {
        public InventorySchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<InventoryQuery>();
        }
    }
}

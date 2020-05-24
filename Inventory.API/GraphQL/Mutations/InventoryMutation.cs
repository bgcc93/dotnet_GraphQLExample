using API_Inventory.GraphQL.Types;
using Domain_Inventory.Infra;
using Domain_Inventory.Model;
using GraphQL;
using GraphQL.Types;
using Inventory.API.GraphQL.Types.Mutations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Mutations
{
    public class InventoryMutation : ObjectGraphType
    {
        public InventoryMutation(IItemRepo itemRepo)
        {
            FieldAsync<ItemType>(
                "createItem",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ItemInputType>> { Name = "item" }),
                resolve: async context =>
                {
                    var item = context.GetArgument<Item>("item");
                    return await context.TryAsyncResolve(async c => (await itemRepo.Add(new List<Item> { item })).FirstOrDefault() );
                }
            );
        }
    }
}

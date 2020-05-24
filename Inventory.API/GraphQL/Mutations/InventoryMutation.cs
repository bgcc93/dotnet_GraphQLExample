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
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<CreateItemInputType>> { Name = "createItem" }),
                resolve: async context =>
                {
                    var item = context.GetArgument<Item>("createItem");
                    return await context.TryAsyncResolve(async c => (await itemRepo.Add(new List<Item> { item })).FirstOrDefault() );
                }
            );
            FieldAsync<ItemType>(
                "updateItem",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<UpdateItemInputType>> { Name = "updateItem" }),
                resolve: async context =>
                {
                    var item = context.GetArgument<Item>("updateItem");
                    return await context.TryAsyncResolve(async c => (await itemRepo.Update(new List<Item> { item })).FirstOrDefault());
                }
            );
        }
    }
}

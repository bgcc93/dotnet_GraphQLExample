using API_Inventory.GraphQL.Types;
using Domain_Inventory.Infra;
using GraphQL;
using GraphQL.Types;
using Inventory.API.GraphQL.Arguments;
using Inventory.Domain.DTO;
using System.Collections.Generic;

namespace API_Inventory.GraphQL.Queries
{
    public class InventoryQuery : ObjectGraphType
    {
        public InventoryQuery(IItemRepo itemRepo)
        {
            Field<ListGraphType<ItemType>>(
                "items",
                //arguments: new ItemQueryArguments(),
                arguments: new QueryArguments(new QueryArgument<ItemSearchArgument>() { Name = "search" }),
                resolve: context => {
                    //var a = ArgumentResolver.GetArgumentTyped<ItemQueryArguments>(context);
                    var item = context.GetArgument<ItemSearchDTO>("search");
                    return itemRepo.GetAll();
                }
            );
            //Field<ListGraphType<MovementType>>(
            //    "movements",
            //    resolve: context => itemRepo.GetAll()
            //);
        }
    }
}

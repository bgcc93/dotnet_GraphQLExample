using API_Inventory.GraphQL.Types;
using Domain_Inventory.Infra;
using GraphQL;
using GraphQL.Types;
using Inventory.API.GraphQL.Arguments;
using System.Collections.Generic;

namespace API_Inventory.GraphQL.Queries
{
    public class InventoryQuery : ObjectGraphType
    {
        public InventoryQuery(IItemRepo itemRepo)
        {
            Field<ListGraphType<ItemType>>(
                "items",
                arguments: new ItemQueryArguments(),
                resolve: context => {
                    var a = ArgumentResolver.GetArgumentTyped<ItemQueryArguments>(context);
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

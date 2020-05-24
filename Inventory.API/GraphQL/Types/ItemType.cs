using Domain_Inventory.Infra;
using Domain_Inventory.Model;
using GraphQL.DataLoader;
using GraphQL.Types;
using Inventory.API.GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Inventory.GraphQL.Types
{
    public class ItemType : ObjectGraphType<Item>
    {
        public ItemType(IMovementRepo movementRepo, IDataLoaderContextAccessor dataLoaderContext)
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Category);
            Field(t => t.DateCreated);
            Field(t => t.SubCategories);
            Field(t => t.Tags);
            Field<ItemStatusEnumType>("ItemStatus", "Description 2");
            Field(
                name: "movements",
                type: typeof(ListGraphType<MovementType>),
                resolve: context => context.Source.Movements
            );

            //Field<ListGraphType<MovementType>>(
            //    "movements",
            //    resolve: context => {
            //        var loader = dataLoaderContext.Context.GetOrAddCollectionBatchLoader<Guid, Movement>("GetMovementsFromItem", movementRepo.GetFromItemLookup);
            //        return loader.LoadAsync(context.Source.Id);
            //    }
            //);
        }
    }
}

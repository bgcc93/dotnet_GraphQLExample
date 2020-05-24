using Domain_Inventory.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Types.Mutations
{
    public class ItemInputType : InputObjectGraphType<Item>
    {
        public ItemInputType()
        {
            Name = "itemInput";
            Field(t => t.Name).Description("Item Name");
            Field(t => t.Upc).Description("Item Name");
            Field(t => t.Category).Description("Item Name");
            Field(t => t.SubCategories, nullable: true).Description("Item Name");
            Field(t => t.Tags, nullable: true).Description("Item Name");
            Field(
                name: "movements",
                type: typeof(ListGraphType<MovementInputType>)
            );
        }
    }
}

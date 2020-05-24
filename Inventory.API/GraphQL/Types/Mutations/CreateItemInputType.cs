using Domain_Inventory.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Types.Mutations
{
    public class CreateItemInputType : InputObjectGraphType<Item>
    {
        public CreateItemInputType()
        {
            Name = "createItemInput";
            Field(t => t.Name).Description("Item Name");
            Field(t => t.Upc).Description("Item's Unique Product Code (basically, Bar Code Number)");
            Field(t => t.Category).Description("Item Category");
            Field(t => t.SubCategories, nullable: true).Description("List of Item's Subcategories");
            Field(t => t.Tags, nullable: true).Description("List of item's Tags");
            Field(
                name: "movements",
                type: typeof(ListGraphType<CreateMovementInputType>)
            );
        }
    }
}

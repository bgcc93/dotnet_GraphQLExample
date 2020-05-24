using Domain_Inventory.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Types.Mutations
{
    public class UpdateItemInputType : InputObjectGraphType<Item>
    {
        public UpdateItemInputType()
        {
            Name = "updateItemInput";
            Field(t => t.Id).Description("Item's ID");
            Field(t => t.Name, nullable: true).Description("Item Name");
            Field(t => t.Upc, nullable: true).Description("Item's Unique Product Code (basically, Bar Code Number)");
            Field(t => t.Category, nullable: true).Description("Item Category");
            Field(t => t.SubCategories, nullable: true).Description("List of Item's Subcategories");
            Field(t => t.Tags, nullable: true).Description("List of item's Tags");
        }
    }
}

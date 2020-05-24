using GraphQL.Types;
using Inventory.API.GraphQL.Types;
using Inventory.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Arguments
{
    public class ItemSearchArgument : InputObjectGraphType<ItemSearchDTO>
    {
        public ItemSearchArgument()
        {
            Name = "ItemSearchType";
            Field(t => t.Name, nullable: true);
            Field(t => t.IsInStock, nullable: true);
            Field(t => t.Description, nullable: true);
            Field(t => t.DateCreated, nullable: true);
            Field(t => t.DateMovement, nullable: true);
            Field<ItemStatusEnumType>("itemStatus");
        }
    }
}

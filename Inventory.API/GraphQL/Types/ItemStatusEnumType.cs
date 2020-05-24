using GraphQL.Types;
using Inventory.Domain.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Types
{
    public class ItemStatusEnumType : EnumerationGraphType<ItemStatusEnum>
    {
        public ItemStatusEnumType()
        {
            Name = "ItemStatus";
            Description = "The status of the item";
        }
    }
}

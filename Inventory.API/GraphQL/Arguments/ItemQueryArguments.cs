using GraphQL.Types;
using Inventory.API.GraphQL.Types;
using Inventory.Domain.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Arguments
{
    public class ItemQueryArguments : BaseArgument
    {
        [QueryArgumentProperty(Name = "name", Description = "Item Name", GraphQLType = typeof(StringGraphType))]
        public string Name { get; set; }

        [QueryArgumentProperty(Name = "description", Description = "Item Description", GraphQLType = typeof(StringGraphType))]
        public string Description { get; set; }

        [QueryArgumentProperty(Name = "isInStock", Description = "Filter for itens in stock", GraphQLType = typeof(BooleanGraphType))]
        public bool? IsInStock { get; set; }

        [QueryArgumentProperty(Name = "dateMovement", Description = "Date the item was created", GraphQLType = typeof(DateTimeGraphType))]
        public DateTime? DateMovement { get; set; }

        [QueryArgumentProperty(Name = "dateCreated", Description = "Date the item was created", GraphQLType = typeof(DateTimeGraphType))]
        public DateTime? DateCreated { get; set; }

        [QueryArgumentProperty(Name = "itemStatus", Description = "The status of the item", GraphQLType = typeof(ItemStatusEnumType))]
        public ItemStatusEnum? ItemStatus { get; set; }

        public ItemQueryArguments() : base(typeof(ItemQueryArguments)) { }
    }
}

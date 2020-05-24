using Domain_Inventory.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Types.Mutations
{
    public class UpdateMovementInputType : InputObjectGraphType<Movement>
    {
        public UpdateMovementInputType()
        {
            Name = "updateMovementInput";
            Field(t => t.Id);
            Field(t => t.ItemId, nullable: true);
            Field(t => t.Quantity, nullable: true);
            Field(t => t.Description, nullable: true);
        }
    }
}

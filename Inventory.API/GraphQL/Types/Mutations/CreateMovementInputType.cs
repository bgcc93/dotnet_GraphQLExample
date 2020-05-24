using Domain_Inventory.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Types.Mutations
{
    public class CreateMovementInputType : InputObjectGraphType<Movement>
    {
        public CreateMovementInputType()
        {
            Name = "createMovementInput";
            Field(t => t.Quantity);
            Field(t => t.Description, nullable: true);
        }
    }
}

using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Types.Mutations
{
    public class MovementInputType : InputObjectGraphType
    {
        public MovementInputType()
        {
            Name = "movementInput";
            Field<NonNullGraphType<IntGraphType>>("quantity");
            Field<StringGraphType>("description");
        }
    }
}

using Domain_Inventory.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Inventory.GraphQL.Types
{
    public class MovementType : ObjectGraphType<Movement>
    {
        public MovementType()
        {
            Field(t => t.Id);
            Field(t => t.Quantity);
            Field(t => t.Description);
            Field(t => t.ItemId);
            Field(t => t.DateCreated);
        }
    }
}

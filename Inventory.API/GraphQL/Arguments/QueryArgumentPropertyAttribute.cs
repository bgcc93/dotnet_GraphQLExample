using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Arguments
{
    [AttributeUsage(AttributeTargets.Property)]
    public class QueryArgumentPropertyAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Type GraphQLType { get; set; }
    }
}

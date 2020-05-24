using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.GraphQL.Arguments
{
    public class BaseArgument : QueryArguments
    {
        public BaseArgument(Type type)
        {
            foreach (var p in type.GetProperties())
            {
                var attr = (QueryArgumentPropertyAttribute[])p.GetCustomAttributes(typeof(QueryArgumentPropertyAttribute), true);
                if (attr.Length > 0)
                {
                    var myAttribute = attr[0];
                    var queryType = myAttribute.GraphQLType;
                    base.Add(new QueryArgument(queryType) { Name = myAttribute.Name, Description = myAttribute.Description });
                }
            }
        }
    }

    public static class ArgumentResolver
    {
        public static T GetArgumentTyped<T>(IResolveFieldContext<object> context) where T : BaseArgument
        {
            var type = typeof(T);
            object o = Activator.CreateInstance(type);

            foreach (var p in o.GetType().GetProperties())
            {
                var attr = (QueryArgumentPropertyAttribute[])p.GetCustomAttributes(typeof(QueryArgumentPropertyAttribute), true);
                if (attr.Length > 0 && context.Arguments.Any(x => x.Key == attr[0].Name))
                {
                    p.SetValue(o, context.Arguments[attr[0].Name]);
                }
            }

            return (T)o;
        }
    }
}

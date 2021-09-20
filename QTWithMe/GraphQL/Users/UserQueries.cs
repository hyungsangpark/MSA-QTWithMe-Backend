using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using QTWithMe.Data;
using QTWithMe.Extensions;
using QTWithMe.Models;

namespace QTWithMe.GraphQL.Users
{
    [ExtendObjectType(name: "Query")]
    public class UserQueries
    {
        [UseAppDbContext]
        [UsePaging]
        public IQueryable<User> GetUsers([ScopedService] AppDbContext context)
        {
            return context.Users;
        }

        [UseAppDbContext]
        public User GetUser(int id, [ScopedService] AppDbContext context)
        {
            return context.Users.Find(id);
        }
    }
}
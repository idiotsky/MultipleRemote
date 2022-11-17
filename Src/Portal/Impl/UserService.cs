using Interface;

namespace Impl
{
    public class UserService : IUserService
    {
        public IList<User> LoadAll()
        {
            return new List<User>
                   {
                       new() { FirstName = "Tom", LastName = "Blue" },
                       new() { FirstName = "Jerry", LastName = "Gray" }
                   };
        }
    }
}

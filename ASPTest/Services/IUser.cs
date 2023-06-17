using ASPTest.Models;

namespace ASPTest.Services
{
    public interface IUser
    {
        public IEnumerable<User> Get();

        public User? Get(int id);

    }
}

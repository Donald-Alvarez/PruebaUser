using ASPTest.Models;

namespace ASPTest.Services
{
    public class UserService : IUser
    {
        private List<User> _User = new List<User>()
        {
            new User(){Id_Usuario = 1, Nombre="Donald"},
            new User(){Id_Usuario = 2, Nombre="Jorge"},
            new User(){Id_Usuario = 3, Nombre="Greeven"}
        };

        public IEnumerable<User> Get() =>_User;
        public User? Get(int id) =>_User.FirstOrDefault(d =>d.Id_Usuario==id);
    }
}

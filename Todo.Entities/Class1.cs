
namespace Todo.Entities
{
    public class UserModel
    {
        public UserModel? GetUser(string email,  string password)
        {
            foreach (var user in _users)
            {
                if (user.Email == email && user.Password = password) 
                {
                return user;
                }
            }
            return null;
        }
    }

}

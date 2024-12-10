using WebApplication1.Cosmos;
using WebApplication1.DTO;

namespace WebApplication1.Orchestrators
{
    public class User : IUser
    {
        private readonly ICosmosDb _cosmos;
        private readonly string userContainer = "user";
        public User(ICosmosDb cosmos) 
        {
            _cosmos = cosmos;
        }
        public Task<UserDTO> GetUserByID(string userID)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDTO>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateUsers(UserUpdateDTO update_users)
        {
            throw new NotImplementedException();
        }
    }
}

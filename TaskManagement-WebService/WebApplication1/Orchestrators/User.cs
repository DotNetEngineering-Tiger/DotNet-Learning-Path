using WebApplication1.Cosmos;
using WebApplication1.DTO;

namespace WebApplication1.Orchestrators
{
    public class User : IUser
    {
        private readonly ICosmosDb<UserDTO> _cosmos;
        private readonly string userContainer = "user";
        public User(ICosmosDb<UserDTO> cosmos) 
        {
            _cosmos = cosmos;
        }

        public Task<UserDTO> create(UserCreateDTO createuser)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO> GetUserByID(string userID)
        {
            return await _cosmos.getItemById(userContainer, userID);
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

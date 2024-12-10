using WebApplication1.DTO;

namespace WebApplication1.Orchestrators
{
    public interface IUser
    {
        public Task<List<UserDTO>> GetUsers();

        public Task<string> UpdateUsers(UserUpdateDTO update_users);

        public Task<UserDTO> GetUserByID (string userID);

       
    }
}

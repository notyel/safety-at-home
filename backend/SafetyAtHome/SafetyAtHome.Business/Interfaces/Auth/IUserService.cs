using SafetyAtHome.Common.Models.Auth;
using SafetyAtHome.Common.Models.DTO.Auth;

namespace SafetyAtHome.Business.Interfaces.Auth
{
    public interface IUserService
    {
        Task<UserDTO> GetUserByIdAsync(Guid id);
        Task<List<UserDTO>> GetAllUsersAsync();
        Task CreateUserAsync(UserModel user);
        Task UpdateUserAsync(UserModel user);
        Task DeleteUserAsync(Guid id);
    }
}

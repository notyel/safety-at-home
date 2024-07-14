using SafetyAtHome.Common.Models.Auth;
using SafetyAtHome.Common.Models.DTO.Auth;

namespace SafetyAtHome.Domain.Repositories.Auth
{
    public interface IUserRepository
    {
        Task<UserDTO> GetByIdAsync(Guid id);
        Task<List<UserDTO>> GetAllAsync();
        Task AddAsync(UserModel user);
        Task UpdateAsync(UserModel user);
        Task DeleteAsync(UserModel user);
    }
}

using SafetyAtHome.Business.Interfaces.Auth;
using SafetyAtHome.Common.Models.Auth;
using SafetyAtHome.Common.Models.DTO.Auth;
using SafetyAtHome.Domain.Repositories.Auth;

namespace SafetyAtHome.Business.Services.Auth
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public async Task<UserDTO> GetUserByIdAsync(Guid id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task CreateUserAsync(UserModel user)
        {
            await _userRepository.AddAsync(user);
        }

        public async Task UpdateUserAsync(UserModel user)
        {
            await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteUserAsync(Guid id)
        {
            await _userRepository.DeleteAsync(new UserModel() { Id = id });
        }
    }
}

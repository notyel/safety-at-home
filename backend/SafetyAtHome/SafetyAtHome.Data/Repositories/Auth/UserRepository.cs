using Microsoft.EntityFrameworkCore;
using AutoMapper;
using SafetyAtHome.Domain.Repositories.Auth;
using SafetyAtHome.Common.Models.DTO.Auth;
using SafetyAtHome.Common.Models.Auth;
using SafetyAtHome.Domain.Entities.Auth;
using SafetyAtHome.Common.Utilities;

namespace SafetyAtHome.Data.Repositories.Auth
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly PasswordHasher _passwordHasher;

        public UserRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _passwordHasher = new PasswordHasher();
        }

        public async Task<UserDTO> GetByIdAsync(Guid id)
        {
            var user = await _context.Users
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();

            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            var users = await _context.Users.ToListAsync();
            return _mapper.Map<List<UserDTO>>(users);
        }

        public async Task AddAsync(UserModel user)
        {
            var entity = _mapper.Map<User>(user);
            entity.PasswordHash = _passwordHasher.Hash(user.Password);

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(UserModel user)
        {
            var entity = _mapper.Map<User>(user);

            entity.PasswordHash = _passwordHasher.Hash(user.Password);
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(UserModel user)
        {
            var entity = _mapper.Map<User>(user);

            _context.Users.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

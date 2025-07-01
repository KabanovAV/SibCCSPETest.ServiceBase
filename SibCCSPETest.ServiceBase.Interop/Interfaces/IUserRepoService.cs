using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface IUserRepoService
    {
        Task<IEnumerable<User>> GetAllUserAsync(Expression<Func<User, bool>>? expression = null, string? includeProperties = null);
        Task<User> GetUserAsync(Expression<Func<User, bool>> expression, string? includeProperties = null);
        Task<User> AddUserAsync(User entity, string? includeProperties = null);
        Task<User> UpdateUser(User entity, string? includeProperties = null);
        void DeleteUser(User entity);
    }
}

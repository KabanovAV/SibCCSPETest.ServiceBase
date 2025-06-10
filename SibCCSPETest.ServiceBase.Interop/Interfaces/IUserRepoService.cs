using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface IUserRepoService
    {
        Task<IEnumerable<User>> GetAllUserAsync(Expression<Func<User, bool>>? expression = null, string? includeProperties = null);
        Task<User> GetUserAsync(Expression<Func<User, bool>> expression, string? includeProperties = null);
        Task AddUserAsync(User entity);
        void UpdateUser(User entity);
        void DeleteUser(User entity);
    }
}

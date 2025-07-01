using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface IGroupRepoService
    {
        Task<IEnumerable<Group>> GetAllGroupAsync(Expression<Func<Group, bool>>? expression = null, string? includeProperties = null);
        Task<Group> GetGroupAsync(Expression<Func<Group, bool>> expression, string? includeProperties = null);
        Task<Group> AddGroupAsync(Group entity, string? includeProperties = null);
        Task<Group> UpdateGroup(Group entity, string? includeProperties = null);
        void DeleteGroup(Group entity);
    }
}

using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface IGroupService
    {
        IEnumerable<Group> GetAllGroup(Expression<Func<Group, bool>>? expression = null, string? includeProperties = null);
        Group GetGroup(Expression<Func<Group, bool>> expression, string? includeProperties = null);
        void AddGroup(Group entity);
        void UpdateGroup(Group entity);
        void DeleteGroup(Group entity);
        void RefreshGroup(Group entity);
    }
}

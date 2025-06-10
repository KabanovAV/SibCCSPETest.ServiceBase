using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public interface IGroupUserRepoService
    {
        Task AddGroupUserAsync(GroupUser entity);
        void UpdateGroupUser(GroupUser entity);
        void DeleteGroupUser(GroupUser entity);
    }
}

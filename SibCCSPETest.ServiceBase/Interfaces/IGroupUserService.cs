using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public interface IGroupUserService
    {
        void AddGroupUser(GroupUser entity);
        void UpdateGroupUser(GroupUser entity);
        void DeleteGroupUser(GroupUser entity);
    }
}

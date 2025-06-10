using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public class GroupUserService : IGroupUserService
    {
        private readonly IRepositoryManager _repository;

        public GroupUserService(IRepositoryManager repository)
            => _repository = repository;

        public void AddGroupUser(GroupUser entity)
        {
            _repository.GroupUser.AddGroupUser(entity);
            _repository.Save();
        }

        public void UpdateGroupUser(GroupUser entity)
        {
            _repository.GroupUser.UpdateGroupUser(entity);
            _repository.Save();
        }

        public void DeleteGroupUser(GroupUser entity)
        {
            _repository.GroupUser.DeleteGroupUser(entity);
            _repository.Save();
        }

        public void RefreshGroupUser(GroupUser entity) => _repository.GroupUser.RefreshGroupUser(entity);
    }
}

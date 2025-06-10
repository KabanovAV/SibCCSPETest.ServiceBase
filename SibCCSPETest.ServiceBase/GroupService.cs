using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class GroupService : IGroupService
    {
        private readonly IRepositoryManager _repository;

        public GroupService(IRepositoryManager repository)
            => _repository = repository;

        public IEnumerable<Group> GetAllGroup(Expression<Func<Group, bool>>? expression = null, string? includeProperties = null)
            => _repository.Group.GetAllGroup(expression, includeProperties);

        public Group GetGroup(Expression<Func<Group, bool>> expression, string? includeProperties = null)
            => _repository.Group.GetGroup(expression, includeProperties);

        public void AddGroup(Group entity)
        {
            _repository.Group.AddGroup(entity);
            _repository.Save();
        }

        public void UpdateGroup(Group entity)
        {
            _repository.Group.UpdateGroup(entity);
            _repository.Save();
        }

        public void DeleteGroup(Group entity)
        {
            _repository.Group.DeleteGroup(entity);
            _repository.Save();
        }

        public void RefreshGroup(Group entity) => _repository.Group.RefreshGroup(entity);
    }
}

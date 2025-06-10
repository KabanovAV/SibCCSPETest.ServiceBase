using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class GroupRepoService : IGroupRepoService
    {
        private readonly IRepositoryManager _repository;

        public GroupRepoService(IRepositoryManager repository)
            => _repository = repository;

        public async Task<IEnumerable<Group>> GetAllGroupAsync(Expression<Func<Group, bool>>? expression = null, string? includeProperties = null)
            => await _repository.Group.GetAllGroupAsync(expression, includeProperties);

        public async Task<Group> GetGroupAsync(Expression<Func<Group, bool>> expression, string? includeProperties = null)
            => await _repository.Group.GetGroupAsync(expression, includeProperties);

        public async Task AddGroupAsync(Group entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ChangedDate = DateTime.Now;
            await _repository.Group.AddGroupAsync(entity);
            _repository.Save();
        }

        public void UpdateGroup(Group entity)
        {
            entity.ChangedDate = DateTime.Now;
            _repository.Group.UpdateGroup(entity);
            _repository.Save();
        }

        public void DeleteGroup(Group entity)
        {
            _repository.Group.DeleteGroup(entity);
            _repository.Save();
        }
    }
}

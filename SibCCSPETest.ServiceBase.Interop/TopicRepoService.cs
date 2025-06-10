using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class TopicRepoService : ITopicRepoService
    {
        private readonly IRepositoryManager _repository;

        public TopicRepoService(IRepositoryManager repository)
            => _repository = repository;

        public async Task<IEnumerable<Topic>> GetAllTopicAsync(Expression<Func<Topic, bool>>? expression = null, string? includeProperties = null)
            => await _repository.Topic.GetAllTopicAsync(expression, includeProperties);

        public async Task<Topic> GetTopicAsync(Expression<Func<Topic, bool>> expression, string? includeProperties = null)
            => await _repository.Topic.GetTopicAsync(expression, includeProperties);

        public async Task AddTopicAsync(Topic entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ChangedDate = DateTime.Now;
            await _repository.Topic.AddTopicAsync(entity);
            _repository.Save();
        }

        public void UpdateTopic(Topic entity)
        {
            entity.ChangedDate = DateTime.Now;
            _repository.Topic.UpdateTopic(entity);
            _repository.Save();
        }

        public void DeleteTopic(Topic entity)
        {
            _repository.Topic.DeleteTopic(entity);
            _repository.Save();
        }
    }
}

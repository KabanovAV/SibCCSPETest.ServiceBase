using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface ITopicRepoService
    {
        Task<IEnumerable<Topic>> GetAllTopicAsync(Expression<Func<Topic, bool>>? expression = null, string? includeProperties = null);
        Task<Topic> GetTopicAsync(Expression<Func<Topic, bool>> expression, string? includeProperties = null);
        Task AddTopicAsync(Topic entity);
        void UpdateTopic(Topic entity);
        void DeleteTopic(Topic entity);
    }
}

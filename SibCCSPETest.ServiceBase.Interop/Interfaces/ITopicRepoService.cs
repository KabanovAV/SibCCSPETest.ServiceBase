using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface ITopicRepoService
    {
        Task<IEnumerable<Topic>> GetAllTopicAsync(Expression<Func<Topic, bool>>? expression = null, string? includeProperties = null);
        Task<Topic> GetTopicAsync(Expression<Func<Topic, bool>> expression, string? includeProperties = null);
        Task<Topic> AddTopicAsync(Topic entity, string? includeProperties = null);
        Task<Topic> UpdateTopic(Topic entity, string? includeProperties = null);
        void DeleteTopic(Topic entity);
    }
}

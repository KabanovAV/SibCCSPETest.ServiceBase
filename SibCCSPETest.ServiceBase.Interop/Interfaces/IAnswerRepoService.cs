using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface IAnswerRepoService
    {
        Task<IEnumerable<Answer>> GetAllAnswerAsync(Expression<Func<Answer, bool>>? expression = null, string? includeProperties = null);
        Task<Answer> GetAnswerAsync(Expression<Func<Answer, bool>> expression, string? includeProperties = null);
        Task<Answer> AddAnswerAsync(Answer entity, string? includeProperties = null);
        Task<IEnumerable<Answer>> AddRangeAnswerAsync(List<Answer> entities, string? includeProperties = null);
        Task<Answer> UpdateAnswer(Answer entity, string? includeProperties = null);
        void DeleteAnswer(Answer entity);
    }
}

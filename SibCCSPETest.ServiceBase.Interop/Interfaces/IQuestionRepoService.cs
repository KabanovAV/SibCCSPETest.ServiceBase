using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface IQuestionRepoService
    {
        Task<IEnumerable<Question>> GetAllQuestionAsync(Expression<Func<Question, bool>>? expression = null, string? includeProperties = null);
        Task<Question> GetQuestionAsync(Expression<Func<Question, bool>> expression, string? includeProperties = null);
        Task<Question> AddQuestionAsync(Question entity, string? includeProperties = null);
        Task<Question> UpdateQuestion(Question entity, string? includeProperties = null);
        void DeleteQuestion(Question entity);
    }
}

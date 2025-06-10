using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface IAnswerService
    {
        IEnumerable<Answer> GetAllAnswer(Expression<Func<Answer, bool>>? expression = null, string? includeProperties = null);
        Answer GetAnswer(Expression<Func<Answer, bool>> expression, string? includeProperties = null);
        void AddAnswer(Answer entity);
        void UpdateAnswer(Answer entity);
        void DeleteAnswer(Answer entity);
        void RefreshAnswer(Answer entity);
    }
}

using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface IResultRepoService
    {
        Task<IEnumerable<Result>> GetAllResultAsync(Expression<Func<Result, bool>>? expression = null, string? includeProperties = null);
        Task<Result> GetResultAsync(Expression<Func<Result, bool>> expression, string? includeProperties = null);
        Task<Result> AddResultAsync(Result entity, string? includeProperties = null);
        Task<Result> UpdateResult(Result entity, string? includeProperties = null);
        void DeleteResult(Result entity);
    }
}

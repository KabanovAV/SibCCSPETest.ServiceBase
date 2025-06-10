using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class ResultRepoService : IResultRepoService
    {
        private readonly IRepositoryManager _repository;

        public ResultRepoService(IRepositoryManager repository)
            => _repository = repository;

        public async Task<IEnumerable<Result>> GetAllResultAsync(Expression<Func<Result, bool>>? expression = null, string? includeProperties = null)
            => await _repository.Result.GetAllResultAsync(expression, includeProperties);

        public async Task<Result> GetResultAsync(Expression<Func<Result, bool>> expression, string? includeProperties = null)
            => await _repository.Result.GetResultAsync(expression, includeProperties);

        public async Task AddResultAsync(Result entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ChangedDate = DateTime.Now;
            await _repository.Result.AddResultAsync(entity);
            _repository.Save();
        }

        public void UpdateResult(Result entity)
        {
            entity.ChangedDate = DateTime.Now;
            _repository.Result.UpdateResult(entity);
            _repository.Save();
        }

        public void DeleteResult(Result entity)
        {
            _repository.Result.DeleteResult(entity);
            _repository.Save();
        }
    }
}

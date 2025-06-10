using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class ResultService : IResultService
    {
        private readonly IRepositoryManager _repository;

        public ResultService(IRepositoryManager repository)
            => _repository = repository;

        public IEnumerable<Result> GetAllResult(Expression<Func<Result, bool>>? expression = null, string? includeProperties = null)
            => _repository.Result.GetAllResult(expression, includeProperties);

        public Result GetResult(Expression<Func<Result, bool>> expression, string? includeProperties = null)
            => _repository.Result.GetResult(expression, includeProperties);

        public void AddResult(Result entity)
        {
            _repository.Result.AddResult(entity);
            _repository.Save();
        }

        public void UpdateResult(Result entity)
        {
            _repository.Result.UpdateResult(entity);
            _repository.Save();
        }

        public void DeleteResult(Result entity)
        {
            _repository.Result.DeleteResult(entity);
            _repository.Save();
        }

        public void RefreshResult(Result entity) => _repository.Result.RefreshResult(entity);
    }
}

using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class AnswerRepoService : IAnswerRepoService
    {
        private readonly IRepositoryManager _repository;

        public AnswerRepoService(IRepositoryManager repository)
            => _repository = repository;

        public async Task<IEnumerable<Answer>> GetAllAnswerAsync(Expression<Func<Answer, bool>>? expression = null, string? includeProperties = null)
            => await _repository.Answer.GetAllAnswerAsync(expression, includeProperties);

        public async Task<Answer> GetAnswerAsync(Expression<Func<Answer, bool>> expression, string? includeProperties = null)
            => await _repository.Answer.GetAnswerAsync(expression, includeProperties);

        public async Task AddAnswerAsync(Answer entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ChangedDate = DateTime.Now;
            await _repository.Answer.AddAnswerAsync(entity);
            _repository.Save();
        }

        public void UpdateAnswer(Answer entity)
        {
            entity.ChangedDate = DateTime.Now;
            _repository.Answer.UpdateAnswer(entity);
            _repository.Save();
        }

        public void DeleteAnswer(Answer entity)
        {
            _repository.Answer.DeleteAnswer(entity);
            _repository.Save();
        }
    }
}

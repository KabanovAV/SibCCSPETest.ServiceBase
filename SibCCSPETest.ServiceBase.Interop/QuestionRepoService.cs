using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class QuestionRepoService : IQuestionRepoService
    {
        private readonly IRepositoryManager _repository;

        public QuestionRepoService(IRepositoryManager repository)
            => _repository = repository;

        public async Task<IEnumerable<Question>> GetAllQuestionAsync(Expression<Func<Question, bool>>? expression = null, string? includeProperties = null)
            => await _repository.Question.GetAllQuestionAsync(expression, includeProperties);

        public async Task<Question> GetQuestionAsync(Expression<Func<Question, bool>> expression, string? includeProperties = null)
            => await _repository.Question.GetQuestionAsync(expression, includeProperties);

        public async Task AddQuestionAsync(Question entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ChangedDate = DateTime.Now;
            await _repository.Question.AddQuestionAsync(entity);
            _repository.Save();
        }

        public void UpdateQuestion(Question entity)
        {
            entity.ChangedDate = DateTime.Now;
            _repository.Question.UpdateQuestion(entity);
            _repository.Save();
        }

        public void DeleteQuestion(Question entity)
        {
            _repository.Question.DeleteQuestion(entity);
            _repository.Save();
        }
    }
}

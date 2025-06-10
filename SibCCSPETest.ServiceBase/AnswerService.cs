using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class AnswerService : IAnswerService
    {
        private readonly IRepositoryManager _repository;

        public AnswerService(IRepositoryManager repository)
            => _repository = repository;

        public IEnumerable<Answer> GetAllAnswer(Expression<Func<Answer, bool>>? expression = null, string? includeProperties = null)
            => _repository.Answer.GetAllAnswer(expression, includeProperties);

        public Answer GetAnswer(Expression<Func<Answer, bool>> expression, string? includeProperties = null)
            => _repository.Answer.GetAnswer(expression, includeProperties);

        public void AddAnswer(Answer entity)
        {
            _repository.Answer.AddAnswer(entity);
            _repository.Save();
        }

        public void UpdateAnswer(Answer entity)
        {
            _repository.Answer.UpdateAnswer(entity);
            _repository.Save();
        }

        public void DeleteAnswer(Answer entity)
        {
            _repository.Answer.DeleteAnswer(entity);
            _repository.Save();
        }

        public void RefreshAnswer(Answer entity) => _repository.Answer.RefreshAnswer(entity);
    }
}

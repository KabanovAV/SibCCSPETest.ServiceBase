//using SibCCSPETest.Data;
//using System.Linq.Expressions;

//namespace SibCCSPETest.ServiceBase
//{
//    public class QuestionService : IQuestionService
//    {
//        private readonly IRepositoryManager _repository;

//        public QuestionService(IRepositoryManager repository)
//            => _repository = repository;

//        public IEnumerable<Question> GetAllQuestion(Expression<Func<Question, bool>>? expression = null, string? includeProperties = null)
//            => _repository.Question.GetAllQuestion(expression, includeProperties);

//        public Question GetQuestion(Expression<Func<Question, bool>> expression, string? includeProperties = null)
//            => _repository.Question.GetQuestion(expression, includeProperties);

//        public void AddQuestion(Question entity)
//        {
//            _repository.Question.AddQuestion(entity);
//            _repository.Save();
//        }

//        public void UpdateQuestion(Question entity)
//        {
//            _repository.Question.UpdateQuestion(entity);
//            _repository.Save();
//        }

//        public void DeleteQuestion(Question entity)
//        {
//            _repository.Question.DeleteQuestion(entity);
//            _repository.Save();
//        }
        
//        public void RefreshQuestion(Question entity) => _repository.Question.RefreshQuestion(entity);
//    }
//}

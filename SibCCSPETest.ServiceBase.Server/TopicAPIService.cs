//using SibCCSPETest.Data;
//using System.Linq.Expressions;

//namespace SibCCSPETest.ServiceBase
//{
//    public class TopicService : ITopicService
//    {
//        private readonly IRepositoryManager _repository;

//        public TopicService(IRepositoryManager repository)
//            => _repository = repository;

//        public IEnumerable<Topic> GetAllTopic(Expression<Func<Topic, bool>>? expression = null, string? includeProperties = null)
//            => _repository.Topic.GetAllTopic(expression, includeProperties);

//        public Topic GetTopic(Expression<Func<Topic, bool>> expression, string? includeProperties = null)
//            => _repository.Topic.GetTopic(expression, includeProperties);

//        public void AddTopic(Topic entity)
//        {
//            _repository.Topic.AddTopic(entity);
//            _repository.Save();
//        }

//        public void UpdateTopic(Topic entity)
//        {
//            _repository.Topic.UpdateTopic(entity);
//            _repository.Save();
//        }

//        public void DeleteTopic(Topic entity)
//        {
//            _repository.Topic.DeleteTopic(entity);
//            _repository.Save();
//        }

//        public void RefreshTopic(Topic entity) => _repository.Topic.RefreshTopic(entity);
//    }
//}

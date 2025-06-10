//using SibCCSPETest.Data;
//using System.Linq.Expressions;

//namespace SibCCSPETest.ServiceBase
//{
//    public class UserService : IUserService
//    {
//        private readonly IRepositoryManager _repository;

//        public UserService(IRepositoryManager repository)
//            => _repository = repository;

//        public IEnumerable<User> GetAllUser(Expression<Func<User, bool>>? expression = null, string? includeProperties = null)
//            => _repository.User.GetAllUser(expression, includeProperties);

//        public User GetUser(Expression<Func<User, bool>> expression, string? includeProperties = null)
//            => _repository.User.GetUser(expression, includeProperties);

//        public void AddUser(User entity)
//        {
//            _repository.User.AddUser(entity);
//            _repository.Save();
//        }

//        public void UpdateUser(User entity)
//        {
//            _repository.User.UpdateUser(entity);
//            _repository.Save();
//        }

//        public void DeleteUser(User entity)
//        {
//            _repository.User.DeleteUser(entity);
//            _repository.Save();
//        }

//        public void RefreshUser(User entity) => _repository.User.RefreshUser(entity);
//    }
//}

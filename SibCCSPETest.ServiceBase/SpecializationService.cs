using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class SpecializationService : ISpecializationService
    {
        private readonly IRepositoryManager _repository;

        public SpecializationService(IRepositoryManager repository)
            => _repository = repository;

        public IEnumerable<Specialization> GetAllSpecialization(Expression<Func<Specialization, bool>>? expression = null, string? includeProperties = null)
            => _repository.Specialization.GetAllSpecialization(expression, includeProperties);

        public Specialization GetSpecialization(Expression<Func<Specialization, bool>> expression, string? includeProperties = null)
            => _repository.Specialization.GetSpecialization(expression, includeProperties);

        public void AddSpecialization(Specialization entity)
        {
            _repository.Specialization.AddSpecialization(entity);
            _repository.Save();
        }

        public void UpdateSpecialization(Specialization entity)
        {
            _repository.Specialization.UpdateSpecialization(entity);
            _repository.Save();
        }

        public void DeleteSpecialization(Specialization entity)
        {
            _repository.Specialization.DeleteSpecialization(entity);
            _repository.Save();
        }

        public void RefreshSpecialization(Specialization entity) => _repository.Specialization.RefreshSpecialization(entity);
    }
}

using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class SpecializationRepoService : ISpecializationRepoService
    {
        private readonly IRepositoryManager _repository;

        public SpecializationRepoService(IRepositoryManager repository)
            => _repository = repository;

        public async Task<IEnumerable<Specialization>> GetAllSpecializationAsync(Expression<Func<Specialization, bool>>? expression = null, string? includeProperties = null)
            => await _repository.Specialization.GetAllSpecializationAsync(expression, includeProperties);

        public async Task<Specialization?> GetSpecializationAsync(Expression<Func<Specialization, bool>> expression, string? includeProperties = null)
            => await _repository.Specialization.GetSpecializationAsync(expression, includeProperties);

        public async Task AddSpecializationAsync(Specialization entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ChangedDate = DateTime.Now;
            await _repository.Specialization.AddSpecializationAsync(entity);
            _repository.Save();
        }

        public void UpdateSpecialization(Specialization entity)
        {
            entity.ChangedDate = DateTime.Now;
            _repository.Specialization.UpdateSpecialization(entity);
            _repository.Save();
        }

        public void DeleteSpecialization(Specialization entity)
        {
            _repository.Specialization.DeleteSpecialization(entity);
            _repository.Save();
        }
    }
}

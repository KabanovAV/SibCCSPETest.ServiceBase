using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface ISpecializationRepoService
    {
        Task<IEnumerable<Specialization>> GetAllSpecializationAsync(Expression<Func<Specialization, bool>>? expression = null, string? includeProperties = null);
        Task<Specialization?> GetSpecializationAsync(Expression<Func<Specialization, bool>> expression, string? includeProperties = null);
        Task AddSpecializationAsync(Specialization entity);
        void UpdateSpecialization(Specialization entity);
        void DeleteSpecialization(Specialization entity);
    }
}

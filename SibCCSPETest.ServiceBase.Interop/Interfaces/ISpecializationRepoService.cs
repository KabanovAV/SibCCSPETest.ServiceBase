using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface ISpecializationRepoService
    {
        Task<IEnumerable<Specialization>> GetAllSpecializationAsync(Expression<Func<Specialization, bool>>? expression = null, string? includeProperties = null);
        Task<Specialization> GetSpecializationAsync(Expression<Func<Specialization, bool>> expression, string? includeProperties = null);
        Task<Specialization> AddSpecializationAsync(Specialization entity, string? includeProperties = null);
        Task<Specialization> UpdateSpecialization(Specialization entity, string? includeProperties = null);
        void DeleteSpecialization(Specialization entity);
    }
}

using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface ISpecializationService
    {
        IEnumerable<Specialization> GetAllSpecialization(Expression<Func<Specialization, bool>>? expression = null, string? includeProperties = null);
        Specialization GetSpecialization(Expression<Func<Specialization, bool>> expression, string? includeProperties = null);
        void AddSpecialization(Specialization entity);
        void UpdateSpecialization(Specialization entity);
        void DeleteSpecialization(Specialization entity);
        void RefreshSpecialization(Specialization entity);
    }
}

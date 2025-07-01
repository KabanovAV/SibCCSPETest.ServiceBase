using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public interface ISpecializationAPIService
    {
        Task<IEnumerable<SpecializationDTO>> GetAllSpecialization();
        Task<IEnumerable<SelectItem>> GetSpecializationSelect();
        Task<SpecializationDTO?> GetSpecialization(int id);
        Task<SpecializationDTO?> AddSpecialization(SpecializationDTO item);
        Task<SpecializationDTO?> UpdateSpecialization(SpecializationDTO item);
        Task DeleteSpecialization(int id);
    }
}

using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public interface ISpecializationAPIService
    {
        Task<IEnumerable<SpecializationDTO>> GetAllSpecialization();
        Task<SpecializationDTO> GetSpecialization(int id);
        Task<SpecializationDTO> AddSpecialization(SpecializationDTO item);
        Task UpdateSpecialization(SpecializationDTO item);
        Task DeleteSpecialization(int id);
    }
}

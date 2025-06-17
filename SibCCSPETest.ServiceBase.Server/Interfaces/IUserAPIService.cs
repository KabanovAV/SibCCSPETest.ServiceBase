using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public interface IUserAPIService
    {
        Task<IEnumerable<UserDTO>> GetAllUser();
        Task<UserDTO?> GetUser(int id);
        Task<UserDTO?> AddUser(UserDTO item);
        Task UpdateUser(UserDTO item);
        Task DeleteUser(int id);
    }
}

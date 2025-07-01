using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public interface IGroupAPIService
    {
        Task<IEnumerable<GroupDTO>> GetAllGroup();
        Task<GroupDTO?> GetGroup(int id);
        Task<GroupDTO?> AddGroup(GroupDTO item);
        Task<GroupDTO?> UpdateGroup(GroupDTO item);
        Task DeleteGroup(int id);
    }
}

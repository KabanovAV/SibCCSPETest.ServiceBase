using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public interface ITopicAPIService
    {
        Task<IEnumerable<TopicDTO>> GetAllTopic();
        Task<TopicDTO?> GetTopic(int id);
        Task<TopicDTO?> AddTopic(TopicDTO item);
        Task<TopicDTO?> UpdateTopic(TopicDTO item);
        Task DeleteTopic(int id);
    }
}

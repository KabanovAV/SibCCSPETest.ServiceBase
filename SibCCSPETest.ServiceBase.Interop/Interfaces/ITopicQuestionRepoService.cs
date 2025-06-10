using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public interface ITopicQuestionRepoService
    {
        Task AddTopicQuestionAsync(TopicQuestion entity);
        void UpdateTopicQuestion(TopicQuestion entity);
        void DeleteTopicQuestion(TopicQuestion entity);
    }
}

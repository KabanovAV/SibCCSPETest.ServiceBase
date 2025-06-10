namespace SibCCSPETest.ServiceBase
{
    public interface IRepoServiceManager
    {
        ISpecializationRepoService SpecializationRepository { get; }
        IAnswerRepoService AnswerRepository { get; }
        IGroupRepoService GroupRepository { get; }
        IQuestionRepoService QuestionRepository { get; }
        IResultRepoService ResultRepository { get; }
        ISettingRepoService SettingRepository { get; }
        IGroupUserRepoService GroupUserRepository { get; }
        ITopicQuestionRepoService TopicQuestionRepository { get; }
        ITopicRepoService TopicRepository { get; }
        IUserRepoService UserRepository { get; }
    }
}

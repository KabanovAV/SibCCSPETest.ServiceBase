namespace SibCCSPETest.ServiceBase
{
    public interface IAPIService
    {
        ISpecializationAPIService SpecializationService { get; }
        IGroupAPIService GroupService { get; }
        ITopicAPIService TopicService { get; }
        IUserAPIService UserService { get; }
        IQuestionAPIService QuestionService { get; }
        IAnswerAPIService AnswerService { get; }

        //IResultService ResultService { get; }
        //ISettingService SettingService { get; }
        //IGroupUserService GroupUserService { get; }
        //ITopicQuestionService TopicQuestionService { get; }
    }
}

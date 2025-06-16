namespace SibCCSPETest.ServiceBase
{
    public interface IAPIService
    {
        ISpecializationAPIService SpecializationService { get; }
        IGroupAPIService GroupService { get; }
        //IAnswerService AnswerService { get; }
        //IQuestionService QuestionService { get; }
        //IResultService ResultService { get; }
        //ISettingService SettingService { get; }
        //IGroupUserService GroupUserService { get; }
        //ITopicQuestionService TopicQuestionService { get; }
        //ITopicService TopicService { get; }
        //IUserService UserService { get; }
    }
}

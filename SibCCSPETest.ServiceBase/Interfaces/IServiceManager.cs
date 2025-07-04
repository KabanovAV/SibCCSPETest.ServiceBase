﻿namespace SibCCSPETest.ServiceBase
{
    public interface IServiceManager
    {
        ISpecializationService SpecializationService { get; }
        IAnswerService AnswerService { get; }
        IGroupService GroupService { get; }
        IQuestionService QuestionService { get; }
        IResultService ResultService { get; }
        ISettingService SettingService { get; }
        IGroupUserService GroupUserService { get; }
        ITopicQuestionService TopicQuestionService { get; }
        ITopicService TopicService { get; }
        IUserService UserService { get; }
    }
}

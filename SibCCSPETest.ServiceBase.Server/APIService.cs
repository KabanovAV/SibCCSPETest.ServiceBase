namespace SibCCSPETest.ServiceBase
{
    public class APIService : IAPIService
    {
        private readonly Lazy<ISpecializationAPIService> _specializationService;
        private readonly Lazy<IGroupAPIService> _groupService;
        //private readonly Lazy<IAnswerService> _answerService;
        //private readonly Lazy<IQuestionService> _questionService;
        //private readonly Lazy<IResultService> _resultService;
        //private readonly Lazy<ISettingService> _settingService;
        //private readonly Lazy<IGroupUserService> _groupUserService;
        //private readonly Lazy<ITopicQuestionService> _topicQuestionService;
        //private readonly Lazy<ITopicService> _topicService;
        //private readonly Lazy<IUserService> _userService;

        public APIService(IHttpClientFactory httpClienFactory)
        {
            _specializationService = new Lazy<ISpecializationAPIService>(() => new SpecializationAPIService(httpClienFactory));
            _groupService = new Lazy<IGroupAPIService>(() => new GroupAPIService(httpClienFactory));
            //_answerService = new Lazy<IAnswerService>(() => new AnswerService(repository));
            //_questionService = new Lazy<IQuestionService>(() => new QuestionService(repository));
            //_resultService = new Lazy<IResultService>(() => new ResultService(repository));
            //_settingService = new Lazy<ISettingService>(() => new SettingService(repository));
            //_groupUserService = new Lazy<IGroupUserService>(() => new GroupUserService(repository));
            //_topicQuestionService = new Lazy<ITopicQuestionService>(() => new TopicQuestionService(repository));
            //_topicService = new Lazy<ITopicService>(() => new TopicService(repository));
            //_userService = new Lazy<IUserService>(() => new UserService(repository));
        }

        public ISpecializationAPIService SpecializationService => _specializationService.Value;
        public IGroupAPIService GroupService => _groupService.Value;

        //public ISpecializationService SpecializationService => _specializationService.Value;
        //public IAnswerService AnswerService => _answerService.Value;
        //public IQuestionService QuestionService => _questionService.Value;
        //public IResultService ResultService => _resultService.Value;
        //public ISettingService SettingService => _settingService.Value;
        //public IGroupUserService GroupUserService => _groupUserService.Value;
        //public ITopicQuestionService TopicQuestionService => _topicQuestionService.Value;
        //public ITopicService TopicService => _topicService.Value;
        //public IUserService UserService => _userService.Value;
    }
}

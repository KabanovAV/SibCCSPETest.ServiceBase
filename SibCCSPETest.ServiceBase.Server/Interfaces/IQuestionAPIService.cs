using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public interface IQuestionAPIService
    {
        Task<IEnumerable<QuestionDTO>> GetAllQuestion();
        Task<QuestionDTO?> GetQuestion(int id);
        Task<QuestionDTO?> AddQuestion(QuestionDTO item);
        Task<QuestionDTO?> UpdateQuestion(QuestionDTO item);
        Task DeleteQuestion(int id);
    }
}

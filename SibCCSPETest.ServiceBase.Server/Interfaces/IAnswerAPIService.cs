using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public interface IAnswerAPIService
    {
        Task<IEnumerable<AnswerDTO>> GetAllAnswer();
        Task<AnswerDTO?> GetAnswer(int id);
        Task<AnswerDTO?> AddAnswer(AnswerDTO item);
        Task<IEnumerable<AnswerDTO>?> AddRangeAnswer(List<AnswerDTO> items);
        Task<AnswerDTO?> UpdateAnswer(AnswerDTO item);
        Task DeleteAnswer(int id);
    }
}

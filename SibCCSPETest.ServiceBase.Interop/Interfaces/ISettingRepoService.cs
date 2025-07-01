using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface ISettingRepoService
    {
        Task<IEnumerable<Setting>> GetAllSettingAsync(Expression<Func<Setting, bool>>? expression = null, string? includeProperties = null);
        Task<Setting> GetSettingAsync(Expression<Func<Setting, bool>> expression, string? includeProperties = null);
        Task<Setting> AddSettingAsync(Setting entity, string? includeProperties = null);
        Task<Setting> UpdateSetting(Setting entity, string? includeProperties = null);
        void DeleteSetting(Setting entity);
    }
}

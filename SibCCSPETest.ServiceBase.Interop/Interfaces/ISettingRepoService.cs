using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface ISettingRepoService
    {
        Task<IEnumerable<Setting>> GetAllSettingAsync(Expression<Func<Setting, bool>>? expression = null, string? includeProperties = null);
        Task<Setting> GetSettingAsync(Expression<Func<Setting, bool>> expression, string? includeProperties = null);
        Task AddSettingAsync(Setting entity);
        void UpdateSetting(Setting entity);
        void DeleteSetting(Setting entity);
    }
}

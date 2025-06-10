using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public interface ISettingService
    {
        IEnumerable<Setting> GetAllSetting(Expression<Func<Setting, bool>>? expression = null, string? includeProperties = null);
        Setting GetSetting(Expression<Func<Setting, bool>> expression, string? includeProperties = null);
        void AddSetting(Setting entity);
        void UpdateSetting(Setting entity);
        void DeleteSetting(Setting entity);
        void RefreshSetting(Setting entity);
    }
}

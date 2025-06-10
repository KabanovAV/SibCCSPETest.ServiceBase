using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class SettingService : ISettingService
    {
        private readonly IRepositoryManager _repository;

        public SettingService(IRepositoryManager repository)
            => _repository = repository;

        public IEnumerable<Setting> GetAllSetting(Expression<Func<Setting, bool>>? expression = null, string? includeProperties = null)
            => _repository.Setting.GetAllSetting(expression, includeProperties);

        public Setting GetSetting(Expression<Func<Setting, bool>> expression, string? includeProperties = null)
            => _repository.Setting.GetSetting(expression, includeProperties);

        public void AddSetting(Setting entity)
        {
            _repository.Setting.AddSetting(entity);
            _repository.Save();
        }

        public void UpdateSetting(Setting entity)
        {
            _repository.Setting.UpdateSetting(entity);
            _repository.Save();
        }

        public void DeleteSetting(Setting entity)
        {
            _repository.Setting.DeleteSetting(entity);
            _repository.Save();
        }

        public void RefreshSetting(Setting entity) => _repository.Setting.RefreshSetting(entity);
    }
}

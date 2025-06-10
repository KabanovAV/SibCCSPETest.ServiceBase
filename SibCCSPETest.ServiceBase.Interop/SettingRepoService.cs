using SibCCSPETest.Data;
using System.Linq.Expressions;

namespace SibCCSPETest.ServiceBase
{
    public class SettingRepoService : ISettingRepoService
    {
        private readonly IRepositoryManager _repository;

        public SettingRepoService(IRepositoryManager repository)
            => _repository = repository;

        public async Task<IEnumerable<Setting>> GetAllSettingAsync(Expression<Func<Setting, bool>>? expression = null, string? includeProperties = null)
            => await _repository.Setting.GetAllSettingAsync(expression, includeProperties);

        public async Task<Setting> GetSettingAsync(Expression<Func<Setting, bool>> expression, string? includeProperties = null)
            => await _repository.Setting.GetSettingAsync(expression, includeProperties);

        public async Task AddSettingAsync(Setting entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ChangedDate = DateTime.Now;
            await _repository.Setting.AddSettingAsync(entity);
            _repository.Save();
        }

        public void UpdateSetting(Setting entity)
        {
            entity.ChangedDate = DateTime.Now;
            _repository.Setting.UpdateSetting(entity);
            _repository.Save();
        }

        public void DeleteSetting(Setting entity)
        {
            _repository.Setting.DeleteSetting(entity);
            _repository.Save();
        }
    }
}

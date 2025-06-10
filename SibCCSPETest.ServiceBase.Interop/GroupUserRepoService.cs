﻿using SibCCSPETest.Data;

namespace SibCCSPETest.ServiceBase
{
    public class GroupUserRepoService : IGroupUserRepoService
    {
        private readonly IRepositoryManager _repository;

        public GroupUserRepoService(IRepositoryManager repository)
            => _repository = repository;

        public async Task AddGroupUserAsync(GroupUser entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.ChangedDate = DateTime.Now;
            await _repository.GroupUser.AddGroupUserAsync(entity);
            _repository.Save();
        }

        public void UpdateGroupUser(GroupUser entity)
        {
            entity.ChangedDate = DateTime.Now;
            _repository.GroupUser.UpdateGroupUser(entity);
            _repository.Save();
        }

        public void DeleteGroupUser(GroupUser entity)
        {
            _repository.GroupUser.DeleteGroupUser(entity);
            _repository.Save();
        }
    }
}

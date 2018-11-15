
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectName.DomainName.Domain.Services
{
    /*
    public abstract class BaseService<TModel> : IBaseService<TModel> where TModel: BaseModel<TModel>, IModel
    {
        private readonly IBaseRepository<TModel> _baseRepository;

        public BaseService(IBaseRepository<TModel> baseRepository)
        {
            this._baseRepository = baseRepository;
        }

        public virtual bool Exists(Guid id)
        {
            bool exists;

            exists = this._baseRepository.Exists(id);

            return exists;
        }

        public virtual bool ExistsWithFind(Guid id)
        {
            bool exists;

            exists = this._baseRepository.ExistsWithFind(id);

            return exists;
        }

        public virtual async Task<TModel> SearchByIdAsync(Guid id)
        {
            TModel item;

            item = await this._baseRepository.SearchByIdAsync(id);

            return item;
        }

        public virtual async Task<IEnumerable<TModel>> GetAllAsync()
        {
            IEnumerable<TModel> collection;

            collection = await this._baseRepository.GetAllAsync();

            return collection;
        }

        public virtual async Task<IEnumerable<TModel>> GetAllAsync(int pageIndex, int pageSize)
        {
            IEnumerable<TModel> collection;

            collection = await this._baseRepository.GetAllAsync(pageIndex, pageSize);

            return collection;
        }

        public virtual async Task<bool> RemoveAsync(Guid id)
        {
            bool removed;

            removed = await this._baseRepository.RemoveAsync(id);

            return removed;
        }

        public virtual async Task<bool> SaveAsync(TModel item)
        {
            bool saved;

            saved = await this._baseRepository.SaveAsync(item);

            await this._baseRepository.CommitAsync();

            return saved;
        }
        
        public virtual async Task<bool> SaveRangeAsync(IEnumerable<TModel> collection)
        {
            bool saved = false;
            
            saved = await this._baseRepository.SaveRangeAsync(collection);

            await this._baseRepository.CommitAsync();

            return saved;
        }
    }
    */
}
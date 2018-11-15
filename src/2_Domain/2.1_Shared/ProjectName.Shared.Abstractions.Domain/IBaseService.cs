
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectName.Shared.Abstractions.Domain
{
    public interface IBaseService<TModel> where TModel : IModel
    {
        bool Exists(Guid id);

        bool ExistsWithFind(Guid id);

        Task<TModel> SearchByIdAsync(Guid id);

        Task<IEnumerable<TModel>> GetAllAsync();

        Task<IEnumerable<TModel>> GetAllAsync(int pageIndex, int pageSize);

        Task<bool> SaveAsync(TModel item);
        
        Task<bool> SaveRangeAsync(IEnumerable<TModel> collection);

        Task<bool> RemoveAsync(Guid id);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
namespace WebApplication2.Infrastructure
{
    public interface IRepository<TEntity,Tkey>where TEntity : class

    {
        Task<IEnumerable<TEntity>>GetAsync();
        Task<IEnumerable<TEntity>> GetAsync(string criteria);
        Task<TEntity> GetByIdAsync(int id);
        Task Upsert(TEntity item);//for both insert and updation
        
        Task DeleteAsync(Tkey id);

    }
}

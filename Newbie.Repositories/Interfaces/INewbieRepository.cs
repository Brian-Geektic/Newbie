using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Repositories.Interfaces
{
    public interface INewbieRepository<T> where T : class
    {
        // 新增一筆資料       
        void Create(T entity);

        // 取得全部資料        
        Task<ICollection<T>> GetAllAsync();

        // 取得單筆資料
        Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate);

        // 刪除資料
        void Delete(T entity);

        // 更新資料
        void Update(T entity);
    }
}

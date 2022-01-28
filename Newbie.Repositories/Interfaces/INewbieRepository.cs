using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Repositories.Interfaces
{
    public interface INewbieRepository<T> : IDisposable where T: class
    {
        // 新增一筆資料       
        void Create(T entity);

        // 取得全部資料        
        IEnumerable<T> GetAll();

        // 取得單筆資料
        T GetById(Expression<Func<T, bool>> predicate);

        // 刪除資料
        void Delete(T entity);

        // 更新資料
        void Update(T entity);

        Task SaveChangesAsync();
        void SaveChanges();
    }
}

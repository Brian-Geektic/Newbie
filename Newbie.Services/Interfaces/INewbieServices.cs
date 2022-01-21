using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.Interfaces
{
    public interface INewbieServices<T> where T : class
    {
        /// <summary>
        /// 新增CRUD的介面
        /// </summary>
        /// <param name="entity"></param>
        void Create(T entity);
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        void Delete(T entity);
        void Update(T entity);
    }
}

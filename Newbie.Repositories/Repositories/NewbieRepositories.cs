using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbie.Repositories.Interfaces;
using Newbie.Repositories.Models;
using Newbie.Repositories.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Newbie.Repositories.Repositories
{
    public class NewbieRepositories<T> : INewbieRepository<T> where T : class
    {
        /// <summary>
        /// 設定UnitOfWork實體
        /// </summary>
        private readonly IUnitOfwork _unitOfwork;
       
        /// <summary>
        /// 實作unitOfWork
        /// </summary>
        /// <param name="context"></param>
        public NewbieRepositories(IUnitOfwork unitOfwork)
        {
            this._unitOfwork = unitOfwork;
        }

        /// <summary>
        /// 新增一筆資料
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _unitOfwork.Context.Set<T>().Add(entity);
        }

        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _unitOfwork.Context.Set<T>().ToListAsync();
        }

        /// <summary>
        /// 取得單筆資料,若取得多筆也只傳入第一筆資料
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<T> GetAsync(Expression<Func<T,bool>> predicate)
        {
            return await _unitOfwork.Context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        /// <summary>
        /// 刪除一筆資料
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            //_context.Set<T>().Remove(entity);
            _unitOfwork.Context.Entry(entity).State = EntityState.Deleted;
        }

        public void Update(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            //_context.Set<T>().Update(entity);
            _unitOfwork.Context.Entry(entity).State = EntityState.Modified;

        }
    }
}

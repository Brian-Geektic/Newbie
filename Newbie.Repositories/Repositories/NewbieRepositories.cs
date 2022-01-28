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
        private NewbiedbContext _context { get; set; }
        public NewbieRepositories(NewbiedbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");
            this._context = context;
        }


        /// 新增一筆資料
        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Set<T>().Add(entity);
        }

        /// 取得所有資料
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        /// 取得單筆資料,若取得多筆也只傳入第一筆資料(要加入AsNoTracking)
        public T GetById(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().AsNoTracking().FirstOrDefault(predicate);
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
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            //_context.Set<T>().Update(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}

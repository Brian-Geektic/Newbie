using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbie.Repositories.Interfaces;
using Newbie.Repositories.Data;
using Newbie.Repositories.Repositories;
using System.Collections;

namespace Newbie.Repositories.UnitOfWork
{
    /// <summary>
    /// 實作UnitOfWork
    /// </summary>
    public class NewbieUnitOfWork : INewbieUnitOfwork
    {
        #region 適用第一種unitofwork interface        
        private bool disposed = false;
        public NewbieUnitOfWork(NewbiedbContext context)
        {
            Context = context;
        }
        public NewbiedbContext Context { get; private set; }
        //儲存所有變更
        public async Task<int> SaveChangeAsync()
        {
            return await Context.SaveChangesAsync();
        }
        //確認刪除class資源
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        //判斷是否正在刪除class資源
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                    Context = null;
                }
            }
            this.disposed = true;
        }
        #endregion


        #region 適用第二種unitofwork interface(較舊,先不用)
        /*
        private readonly NewbiedbContext _context;
        private bool _disposed;
        private Hashtable _respositories;
        public NewbieUnitOfWork(NewbiedbContext context)
        {
            _context = context;
        }
        
        //儲存所有異動
        public void Save()
        {
            _context.SaveChanges();
        }
        
        //確認清除class的資源
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //判斷是否正在清除資源
        protected virtual void Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        //取得一個entity的repository,若無則新建一個,若有就用之前的
        public INewbieRepository<T> NewbieRepository<T> where T : class
        {
            if(_respositories == null)
            {
                _respositories = new Hashtable();
            }
            var type = typeof(T).Name;
            if (!_respositories.ContainsKey(type))
            {
                var repositoryType = typeof(NewbieRepositories<>);
                var respositoryInstance =
                    Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
                _respositories.Add(type, respositoryInstance);
            }
            return (INewbieRepository<T>)_respositories[type];
        } */

        #endregion



    }
}

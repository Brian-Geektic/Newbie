using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbie.Repositories.Data;

namespace Newbie.Repositories.Interfaces
{
    /// <summary>
    /// 設定UnitOfWork介面
    /// </summary>
    public interface IUnitOfwork : IDisposable
    {
        NewbiedbContext Context { get; }
        //void Save();
        //INewbieRepository<T> NewbieRepository<T>() where T : class;
        /// <summary>
        /// 資料儲存
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangeAsync();
    }

    /// <summary>
    /// 實作UnitOfWork
    /// </summary>
    public class UnitOfWork : IUnitOfwork
    {
        private bool disposed = false;

        public UnitOfWork(NewbiedbContext context)
        {
            Context = context;
        }
        public NewbiedbContext Context { get; private set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await Context.SaveChangesAsync();
        }

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
    }
}

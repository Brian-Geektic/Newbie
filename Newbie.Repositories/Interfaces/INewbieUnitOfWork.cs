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
    public interface INewbieUnitOfwork : IDisposable
    {
        //第一種方式
        NewbiedbContext Context { get; }
        Task<int> SaveChangeAsync();


        //第二種方式 
        //void Save();
        //取得Repository
        //INewbieRepository<T> NewbieRepository<T>() where T : class;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.Interfaces
{
    public interface INewbieServices
    {
        /// <summary>
        /// 新增CRUD的介面
        /// </summary>
        /// <param name="entity"></param>
        void Create(Project entity);
        void Delete(Project entity);
        void Update(Project entity);

        IEnumerable<Project> GetAll();
        bool IsExists(int id);

        Project GetById(int id);
        //Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        
    }
}

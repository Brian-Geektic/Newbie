using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newbie.Repositories.Data;
using Newbie.Repositories.Models;
using Newbie.Repositories.Interfaces;

namespace Newbie.Repositories.Repositories
{

    public class RoleArticleRepositories : NewbieRepositories<RoleArticle>, IRolearticleRepository
    {
        #region 全部實作
        /*
        private readonly NewbiedbContext _context;
        public RoleArticleRepositories(NewbiedbContext context)
        {
            _context = context;
        }
        public IEnumerable<RoleArticle> GetRolearticles()
        {
            return _context.RoleArticles.ToList();
        }
        public RoleArticle GetRolearticleByID(int id)
        {
            return _context.RoleArticles.Find(id);
        }
        public void CreateRolearticle(RoleArticle rolearticle)
        {
            _context.RoleArticles.Add(rolearticle);
        }
        public void UpdateRolearticle(RoleArticle rolearticle)
        {
            _context.Entry(rolearticle).State = EntityState.Modified;
        }
        public void DeleteRolearticle(int rolearticleId)
        {
            RoleArticle rolearticle = _context.RoleArticles.Find(rolearticleId);
            _context.RoleArticles.Remove(rolearticle);
        }
        public void Save()
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
        */
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newbie.Repositories.Interfaces;
using Newbie.Repositories.Data;
using Newbie.Repositories.Models;

namespace Newbie.Repositories.Repositories
{
    public class AuthorizationRepositories : NewbieRepositories<Authorization>, IAuthorizationRepository
    {
        public AuthorizationRepositories(NewbiedbContext context) : base(context)
        {

        }

        #region 全部實作
        /*
        private readonly NewbiedbContext _context;
        public AuthorizationRepositories(NewbiedbContext context)
        {
            _context = context;
        }
        public IEnumerable<Authorization> GetAuthorizations()
        {
            return _context.Authorizations.ToList();
        }
        public Authorization GetAuthorizationByID(int id)
        {
            return _context.Authorizations.Find(id);
        }
        public void CreateAuthorization(Authorization authorization)
        {
            _context.Authorizations.Add(authorization);
        }
        public void UpdateAuthorization(Authorization authorization)
        {
            _context.Entry(authorization).State = EntityState.Modified;
        }
        public void DeleteAuthorization(int roleId)
        {
            Role role = _context.Roles.Find(roleId);
            _context.Roles.Remove(role);
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
        }*/
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbie.Repositories.Data;
using Newbie.Repositories.Models;
using Newbie.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Newbie.Repositories.Repositories
{
    public class RoleRepositories : NewbieRepositories<Role>, IRoleRepository
    {

        #region 全部實作
        /*
        private readonly NewbiedbContext _context;
        public RoleRepositories(NewbiedbContext context)
        {
            _context = context;
        }
        public IEnumerable<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }
        public Role GetRoleByID(int id)
        {
            return _context.Roles.Find(id);
        }
        public void CreateRole(Role role)
        {
            _context.Roles.Add(role);
        }
        public void UpdateRole(Role role)
        {
            _context.Entry(role).State = EntityState.Modified;
        }
        public void DeleteRole(int roleId)
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
        }
        */
        #endregion
    }
}

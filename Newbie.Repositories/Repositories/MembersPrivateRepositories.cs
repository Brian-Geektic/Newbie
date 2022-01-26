using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbie.Repositories.Interfaces;
using Newbie.Repositories.Models;
using Newbie.Repositories.Data;
using Microsoft.EntityFrameworkCore;

namespace Newbie.Repositories.Repositories
{
    public class MembersPrivateRepositories : NewbieRepositories<MembersPrivate>, IMemberprivateRepository
    {
        public MembersPrivateRepositories(NewbiedbContext context) : base(context)
        {

        }
        #region 全部實作
        /*
        private readonly NewbiedbContext _context;
        public MembersPrivateRepositories(NewbiedbContext context)
        {
            _context = context;
        }
        public IEnumerable<MembersPrivate> GetMemberPrivates()
        {
            return _context.MembersPrivates.ToList();
        }
        public MembersPrivate GetMemberPrivateByID(int id)
        {
            return _context.MembersPrivates.Find(id);
        }
        public void CreateMemberPrivate(MembersPrivate memebersPrivate)
        {
            _context.MembersPrivates.Add(memebersPrivate);
        }
        public void UpdateMemeberPrivate(MembersPrivate membersPrivate)
        {
            _context.Entry(membersPrivate).State = EntityState.Modified;
        }
        public void DeleteMemberPrivate(int MembersprivateId)
        {
            MembersPrivate membersPrivate = _context.MembersPrivates.Find(MembersprivateId);
            _context.MembersPrivates.Remove(membersPrivate);
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

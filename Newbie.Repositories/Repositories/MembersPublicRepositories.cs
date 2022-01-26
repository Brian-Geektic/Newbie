using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbie.Repositories.Interfaces;
using Newbie.Repositories.Data;
using Newbie.Repositories.Models;
using Microsoft.EntityFrameworkCore;

namespace Newbie.Repositories.Repositories
{
    public class MembersPublicRepositories : NewbieRepositories<MembersPublic>, IMemberpublicRepository
    {
        public MembersPublicRepositories(NewbiedbContext context) : base(context)
        {

        }
        #region 全部實作
        /*
        private readonly NewbiedbContext _context;

        public MembersPublicRepositories(NewbiedbContext context)
        {
            _context = context;
        }
        public IEnumerable<MembersPublic> GetMemberPublics()
        {
            return _context.MembersPublics.ToList();
        }
        public MembersPublic GetMemberPublicByID(int id)
        {
            return _context.MembersPublics.Find(id);
        }
        public void CreateMemberPublic(MembersPublic memebersPublic)
        {
            _context.MembersPublics.Add(memebersPublic);
        }
        public void UpdateMemeberPublic(MembersPublic membersPublic)
        {
            _context.Entry(membersPublic).State = EntityState.Modified;
        }
        public void DeleteMemberPublic(int MemberspublicId)
        {
            MembersPublic membersPublic = _context.MembersPublics.Find(MemberspublicId);
            _context.MembersPublics.Remove(membersPublic);
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

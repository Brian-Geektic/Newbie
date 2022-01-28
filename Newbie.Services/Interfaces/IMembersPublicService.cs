using Newbie.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.Interfaces
{
    public interface IMembersPublicService
    {
        #region 全部列出

        void Create(MemberPublicDto memberPublicDto);
        Task CreateAsync(MemberPublicDto memberpublicdto);
        void Delete(MemberPublicDto memberpublicdto);        
        void Update(MemberPublicDto memberpublicdto);
        Task UpdateAsync(MemberPublicDto memberPublicDto);
        IEnumerable<MemberPublicDto> GetAll();
        MemberPublicDto GetById(int id);
        bool IsExisted(string name);
        
        #endregion
    }
}

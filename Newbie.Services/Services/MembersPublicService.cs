using AutoMapper;
using Newbie.Repositories.Interfaces;
using Newbie.Repositories.Models;
using Newbie.Services.Dto;
using Newbie.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Newbie.Services.Services
{
    public class MembersPublicService : IMembersPublicService
    {
        protected IMemberpublicRepository _memberpublicRepository;
        protected readonly IMapper _mapper;
        public MembersPublicService(IMemberpublicRepository memberpublicRepository, IMapper mapper)
        {
            _memberpublicRepository = memberpublicRepository;
            _mapper = mapper;
        }

        public void Create(MemberPublicDto memberpublicdto)
        {
            memberpublicdto.MemberId = memberpublicdto.MemberId;
            memberpublicdto.Accountname = memberpublicdto.Accountname;
            memberpublicdto.Firstname = memberpublicdto.Firstname;
            memberpublicdto.Lastname = memberpublicdto.Lastname;
            memberpublicdto.Nickname = memberpublicdto.Nickname;
            memberpublicdto.Intro = memberpublicdto.Intro;
            memberpublicdto.Joindate = DateTime.Now;
            memberpublicdto.MemberspublicId = memberpublicdto.MemberspublicId; //要再修改成auto-increment

            _memberpublicRepository.Create(_mapper.Map<MembersPublic>(memberpublicdto));
            _memberpublicRepository.SaveChanges();
        }

        public void Delete(MemberPublicDto memberpublicdto)
        {
            var oldmemberpublic = GetById(memberpublicdto.MemberspublicId);
            _memberpublicRepository.Delete(_mapper.Map<MembersPublic>(memberpublicdto)); //要再確認一下這樣寫是對的嗎?
            _memberpublicRepository.SaveChanges();
        }

        public IEnumerable<MemberPublicDto> GetAll()
        {
            var allmemberpublic = _memberpublicRepository.GetAll();
            return _mapper.Map<List<MemberPublicDto>>(allmemberpublic);
        }

        public MemberPublicDto GetById(int id)
        {
            return _mapper.Map<MemberPublicDto>(_memberpublicRepository.GetById(m => m.MemberspublicId == id));
        }

        public void Update(MemberPublicDto memberpublicdto)
        {
            var oldmemberpublic = GetById(memberpublicdto.MemberspublicId);
            oldmemberpublic.MemberspublicId = memberpublicdto.MemberspublicId; //待改成auto-increment
            oldmemberpublic.MemberId = memberpublicdto.MemberId;
            oldmemberpublic.Accountname = memberpublicdto.Accountname;
            oldmemberpublic.Firstname = memberpublicdto.Firstname;
            oldmemberpublic.Lastname = memberpublicdto.Lastname;
            oldmemberpublic.Nickname = memberpublicdto.Nickname;
            oldmemberpublic.Intro = memberpublicdto.Intro;
            oldmemberpublic.Joindate = oldmemberpublic.Joindate;  //如果沒有要變,寫這樣子嗎?

            _memberpublicRepository.Update(_mapper.Map<MembersPublic>(memberpublicdto));
            _memberpublicRepository.SaveChanges();

        }
        public bool IsExisted(string accountname)
        {
            var memberpublicExisted = _memberpublicRepository.GetById(m => m.Accountname == accountname);
            return memberpublicExisted == null ? true : false;
        }
    }
}

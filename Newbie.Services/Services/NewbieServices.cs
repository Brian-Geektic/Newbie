using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbie.Services.Interfaces;
using Newbie.Repositories.Data;
using Newbie.Repositories.Models;
using Newbie.Repositories.Interfaces;
using AutoMapper;
using Newbie.Repositories.Repositories;
using System.Linq.Expressions;
using AutoMapper;

namespace Newbie.Services.Services
{
    public class NewbieServices : INewbieServices
    {
        #region 舊程式碼
        /*
        protected INewbieRepository<TDto> _newbieRepository;
        protected readonly IMapper _mapper;
        public NewbieServices(INewbieRepository<TDto> newbieRepository, IMapper mapper)
        {
            _newbieRepository = newbieRepository;
            _mapper = mapper;
        }


        public void Create(TDto dto)
        {
            

        }

        public void Delete(TDto dto)
        {
            throw new NotImplementedException();
        }

        public void Update(TDto dto)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TDto> INewbieServices<TDto>.GetAll()
        {
            throw new NotImplementedException();
        }

        public TDto GetById(Expression<Func<TDto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TDto GetById(int id)
        {
            throw new NotImplementedException();
        }
        */
        #endregion
    }
}

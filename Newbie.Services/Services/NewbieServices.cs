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



namespace Newbie.Services.Services
{
    public class NewbieServices : INewbieServices
    {
        private INewbieRepository<Article> _articleRepositories;
        private IMapper _mapper;
        private INewbieUnitOfwork _unitofwork;
        
        //建立新的新的實體
        public NewbieServices(
            INewbieUnitOfwork unitofwork,
            INewbieRepository<Article> articlerepository,
            Mapper mapper)
        {
            _unitofwork = unitofwork;
            _articleRepositories = articlerepository;
            _mapper = mapper;
        }

        public async Task<int> Create(ArticleDto articleDto)
        {
            var article = _mapper.Map<Article>(articleDto);
            _articleRepositories.Create(article);
            return await this._unitofwork.SaveChangeAsync();
        }

        //Create

        //GetAllAsync
        //GetAsync
        //Delete
        //Update

    }
}

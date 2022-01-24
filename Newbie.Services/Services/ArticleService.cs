using Newbie.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbie.Repositories.Interfaces;
using Newbie.Repositories.Repositories;
using Newbie.Services.Misc;
using Newbie.Services.Dto;
using Newbie.Repositories.Models;

namespace Newbie.Services.Services
{
    public class ArticleService : IArticleServices
    {
        private INewbieRepository<Article> _newbieRespositories = new NewbieRepositories<Article>();
        ArticleDto articleDto = new ArticleDto();

        public IResult Create(ArticleDto articleDto)
        {
            if (articleDto == null)
                throw new ArgumentNullException();
            IResult result = new Result(false);
            try
            {
                this._newbieRespositories.Create(article);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }
            return result;
        }
        public IResult Update(ArticleDto articleDto)
        {
            if (articleDto == null)
                throw new ArgumentNullException();
            IResult result = new Result(false);
            try
            {
                this._newbieRespositories.Update(articleDto);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }
            return result;
        }
        public IResult Delete(int articleId)
        {
            IResult result = new Result(false);
            if (!this.IsExists(articleId))
                result.Message = "找不到資料";
            try
            {
                var articleDtoinstance = this.GetById(articleId);
                this._newbieRespositories.Delete(articleDtoinstance);
                result.Success = true;
            }
            catch(Exception ex)
            {
                result.Exception = ex;
            }
            return result;
        }
        public ArticleDto GetById(int articleDtoId)
        {
            return this._newbieRespositories.Get(x => x.ArticleId == articleDtoId);
        }

        public IEnumerable<ArticleDto> GetAll()
        {
            return this._newbieRespositories.GetAll();
        }


        public bool IsExists(int articleDtoId)
        {
            return this._newbieRespositories.GetAll().Any(x => x.ArticleId == articleDtoId);
        }

       
    }
}

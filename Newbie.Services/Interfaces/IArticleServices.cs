using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbie.Services.Dto;
using Newbie.Repositories.Repositories;
using Newbie.Services.Misc;


namespace Newbie.Services.Interfaces
{
    
    public interface IArticleServices
    {
        IResult Create(ArticleDto articleDto);
        IResult Update(ArticleDto articleDto);
        IResult Delete(int articleId);
        bool IsExists(int articleId);
        ArticleDto GetById(int articleId);
        IEnumerable<ArticleDto> GetAll();
       
    }
}

using Newbie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Newbie.Repositories.Repositories
{
    public class ArticleRepository
    {
        private readonly INewbieUnitOfwork _unitOfwork;
        public ArticleRepository(INewbieUnitOfwork unitOfwork)
        {
            _unitOfwork = unitOfwork;
        }

    }
}

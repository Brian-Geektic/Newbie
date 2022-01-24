using Newbie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newbie.Repositories.Data;
using Newbie.Repositories.Repositories;
using Newbie.Repositories.Models;


namespace Newbie.Repositories.Repositories
{
    public class ArticleRepositories : NewbieRepositories<Article>, IArticleRepository
    {

    }
}

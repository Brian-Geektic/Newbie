using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newbie.Services.Dto;

namespace Newbie.Web.ViewModels
{
    public class ArticleDetailsVM
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newbie.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newbie.Repositories.Interfaces;
using Newbie.Repositories.Repositories;
using Newbie.Repositories.Models;
using Newbie.Repositories.Data;
using System.Data;

namespace Newbie.Web.Controllers
{
    public class HomeController : Controller
    {
        private INewbieRepository<Article> _articleRepository;

        public HomeController()
        {
            this._articleRepository = new NewbieRepositories<Article>(new NewbiedbContext());
        }

        public ActionResult Index()
        {
            var article = this._articleRepository.GetAll()
              .OrderByDescending(x => x.ArticleId).ToList();
            return View(article);
        }

        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
                return RedirectToAction("index");
            else
            {
                var article = this._articleRepository.GetById(x => x.ArticleId == id.Value);
                return View(article);
            }
        }

        [HttpPost]
        public ActionResult Create(Article article)
        {
            if (article != null && ModelState.IsValid)
            {
                _articleRepository.Create(article);
                return RedirectToAction("index");
            }
            else
            {
                return View(article);
            }
        }

        [HttpPost]
        public ActionResult Update(Article article)
        {
            if (article != null && ModelState.IsValid)
            {
                _articleRepository.Update(article);
                return View(article);
            }
            else
            {
                return RedirectToAction("index");
            }
        }
        public ActionResult Delete(int? id)
        {
            if (!id.HasValue)
                return RedirectToAction("index");
            else
            {
                var article = this._articleRepository.GetById(x => x.ArticleId == id.Value);
                return View(article);
            }
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            try
            {
                var article = this._articleRepository.GetById(x => x.ArticleId == id);
                _articleRepository.Delete(article);
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new { id=id});
            }
            return RedirectToAction("index");
        }
        public IActionResult Privacy()
        {
            //Article art = _context.Articles.FirstOrDefault();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

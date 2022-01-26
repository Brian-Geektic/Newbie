using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newbie.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Newbie.Services.Interfaces;
using Newbie.Services.Services;

namespace Newbie.Web.Controllers
{
    public class HomeControllerold : Controller
    {
        #region 隱藏舊程式碼
        /*
        private readonly INewbieServices _newbieServices;
        public HomeControllerold()
        {
            this._newbieServices = new NewbieServices();
        }

        public ActionResult Index()
        {
            var projects = projectService.GetAll();
            var viewModel = new ProjectListViewModel();
            viewModel.ProjectList = projects;
            return View(viewModel);
        }

        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
                return RedirectToAction("index");
            else
            {
                var article = this._newbieServices.GetById(x => x.ArticleId == id.Value);
                return View(article);
            }
        }

        [HttpPost]
        public ActionResult Create(Article article)
        {
            var viewModel = new ProjectViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Update(Article article)
        {
            if (article != null && ModelState.IsValid)
            {
                _newbieServices.Update(article);
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
                var article = this._newbieServices.GetById(x => x.ArticleId == id.Value);
                return View(article);
            }
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            try
            {
                var article = this._newbieServices.GetById(x => x.ArticleId == id);
                _newbieServices.Delete(article);
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new { id = id });
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
        */
        #endregion
    }
}

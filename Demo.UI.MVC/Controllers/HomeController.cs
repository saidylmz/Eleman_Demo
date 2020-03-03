using Demo.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        IAdvertService advertService;
        ICategoryService categoryService;

        public HomeController(IAdvertService advertService, ICategoryService categoryService)
        {
            this.advertService = advertService;
            this.categoryService = categoryService;
        }
        public ActionResult Index()
        {
            ViewBag.Favs = categoryService.GetAll().Where(x => !string.IsNullOrEmpty(x.FavImage));
            return View(advertService.GetAll());
        }
    }
}
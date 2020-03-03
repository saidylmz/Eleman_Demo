using Demo.BLL.Abstract;
using Demo.MODEL.Entities;
using Demo.UI.MVC.Tools.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.UI.MVC.Controllers
{
    public class AdvertController : Controller
    {
        IAdvertService advertService;
        public AdvertController(IAdvertService advertService)
        {
            this.advertService = advertService;
        }
        public ActionResult Index(string permalink)
        {
            Advert advert = advertService.GetAll().First(x => x.ToUrlString() == permalink);
            if (advert == null)
                return RedirectToAction("Index", controllerName: "Home");
            return View(advert);
        }
    }
}
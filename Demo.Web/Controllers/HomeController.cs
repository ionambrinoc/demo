﻿namespace Demo.Web.Controllers
{
    using System.Web.Mvc;

    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}

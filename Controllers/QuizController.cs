using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WebApplication2.DataContext;

namespace WebApplication2.Controllers
{
    public class QuizController : Controller
    {
        // Действие для отображения главной страницы викторин
        public ActionResult Index()
        {
            return View("Index");
        }

    }
}
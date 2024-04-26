using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DataContext;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CrosswordController : Controller
    {

       // Общий метод для получения данных кроссворда из базы данных, избегаем дублирования кода

        // Действие для отображения главной страницы кроссвордов
        public ActionResult Index()
        {
             return View("Index");
        }


    }
}
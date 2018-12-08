using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PathOfExile.Models;
using PathOfExile.DAL;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace PathOfExile.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            CharacterSqlDAL dal = new CharacterSqlDAL();
            return View(dal.GetAllCharacters());
        }

        public IActionResult Detail(int id)
        {
            CharacterSqlDAL dal = new CharacterSqlDAL();
            CharacterModel character = dal.GetCharacter(id);

            return View(character);
        }

        public IActionResult CurrencyView()
        {
            CurrencySqlDAL dal = new CurrencySqlDAL();
            
            return View(dal.GetAllCurrency());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Tips()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

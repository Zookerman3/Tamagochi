using Microsoft.AspNetCore.Mvc;
using Game.Models;
using System;
using System.Collections.Generic;

namespace Game.Controllers
{
    public class TamagochisController : Controller
    {

        [HttpGet("/tamagochis")]
        public ActionResult Index()
        {
            List<Tamagochi> allTamagochis = Tamagochi.GetAll();
            return View(allTamagochis);
        }

        [HttpGet("/tamagochis/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/tamagochis")]
        public ActionResult Create(string name, int food, int attention, int rest)
        {
            Tamagochi myTamagochi = new Tamagochi(name, food, attention, rest);
            return RedirectToAction("Index");
        }

        [HttpPost("/tamagochis/delete")]
        public ActionResult DeleteAll()
        {
            Tamagochi.ClearAll();
            return View();
        }

        [HttpGet("/tamagochis/show")]
        public ActionResult Show()
        {
            List<Tamagochi> allTamagochis = Tamagochi.GetAll();
            return View(allTamagochis);
        }

        [HttpPost("/tamagochis/show/food")]
        public ActionResult Food(string name, int food)
        {
            Tamagochi.FeedPet(name, food);
            return View();
        }

        [HttpPost("/tamagochis/show/attention")]
        public ActionResult Attention(string name, int attention)
        {
            Tamagochi.PraisePet(name, attention);
            return View();
        }

        [HttpPost("/tamagochis/show/rest")]
        public ActionResult Rest(string name, int rest)
        {
            Tamagochi.RestPet(name, rest);
            return View();
        }

    }
}
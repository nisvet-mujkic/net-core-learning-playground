using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiControllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiControllers.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index() => View(repository.Reservations);

        [HttpPost]
        public IActionResult Add(Reservation reservation)
        {
            repository.Add(reservation);
            return RedirectToAction(nameof(Index));
        }
    }
}
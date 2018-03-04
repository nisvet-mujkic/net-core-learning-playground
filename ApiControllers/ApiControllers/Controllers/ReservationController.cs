using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiControllers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiControllers.Controllers
{
    //[Produces("application/json")]
    //[Route("api/Reservation")]
    [Route("api/[controller]")]
    public class ReservationController : Controller
    {
        private readonly IRepository repository;

        public ReservationController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Reservation> Get() => repository.Reservations;

        [HttpGet("{id}")]
        public Reservation Get(int id) => repository[id];

        [HttpPost]
        public Reservation Post([FromBody]Reservation reservation) => repository.Add(new Reservation() { ClientName = reservation.ClientName, Location = reservation.Location });

        [HttpPut]
        public Reservation Put([FromBody]Reservation reservation) => repository.Update(reservation);

        [HttpDelete("{id}")]
        public void Delete(int id) => repository.Delete(id);
    }
}
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
    //[Route("api/Content")]
    [Route("api/[controller]")]
    public class ContentController : Controller
    {

        [HttpGet("string")]
        public string GetString() => "E svasta";

        [HttpGet("object")]
        public Reservation GetObject() => new Reservation() { Id = 100, ClientName = "Nisvet Mujkic", Location = "Mostar" };
    }
}
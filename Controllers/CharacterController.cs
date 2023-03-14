// global using PatrickGODWebApiEF7SQL.Models;
//https://www.youtube.com/watch?v=9zJn3a7L1uE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PatrickGODWebApiEF7SQL.Controllers
{
    [ApiController] //timestamp 30:00
    [Route("api/[controller]")] //api/Character   showed the Knight object on the browser..?
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(), new Character {Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle()
        {
            return Ok(characters[0]);
        }

        //COntinue from 48:00  https://www.youtube.com/watch?v=9zJn3a7L1uE
    }
}

//SCRAP

// private readonly ILogger<CharacterController> _logger;

//         public CharacterController(ILogger<CharacterController> logger)
//         {
//             _logger = logger;
//         }

//         public IActionResult Index()
//         {
//             return View();
//         }

//         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//         public IActionResult Error()
//         {
//             return View("Error!");
//         }
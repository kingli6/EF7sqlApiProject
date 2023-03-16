// global using PatrickGODWebApiEF7SQL.Models;
//https://www.youtube.com/watch?v=9zJn3a7L1uE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PatrickGODWebApiEF7SQL.Models;
// using PatrickGODWebApiEF7SQL.Services.CharacterService;

namespace PatrickGODWebApiEF7SQL.Controllers
{
    [ApiController] //timestamp 30:00
    [Route("api/[controller]")] //api/Character   Character is the controllers name
    public class CharacterController : ControllerBase
    {
        private static ModelA modelAObject = new ModelA();  //

        private static List<Character> characters = new List<Character>{
            new Character(), new Character {Id = 1, Name = "Sam"}
        };
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }


        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {

            return Ok(await _characterService.AddCharacter(newCharacter));
        }


        //my stufff


        [HttpGet("modelA/GetAll")]
        public ActionResult<ModelA> GetmodelA()
        {
            return Ok(modelAObject);
        }
        //COntinue from 48:00  https://www.youtube.com/watch?v=9zJn3a7L1uE


        // //Notes
        // public Charactar GetCharactedById(int id){
        //     var character = character.FirstOrDefault(c => c.id == id);
        //     if (character is not null)
        //         return character;

        //     throw new Exception("Character not found");
        // }
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
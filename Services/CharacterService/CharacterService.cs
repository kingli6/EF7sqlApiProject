using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PatrickGODWebApiEF7SQL.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            new Character(), new Character {Id = 1, Name = "Sam"}
        };
        private readonly IMapper _mapper;   //1:26:00  https://www.youtube.com/watch?v=9zJn3a7L1uE&list=WL&index=5&t=5134s

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>(); //?? I need a stepByStep 
            var character = _mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c => c.Id) + 1;   //creating a new object with an id that is appropriate. otherwise you get id=0. do we not have this problem by using database? A. correct, Your db will assign it. 1:34:00 https://www.youtube.com/watch?v=9zJn3a7L1uE&list=WL&index=6&t=5134s

            characters.Add(character);
            serviceResponse.Data = characters.Select(x => _mapper.Map<GetCharacterDto>(x)).ToList();    //Select returns a Ienumerable. Tip: Look at what methods are at work when you get red 1:28:00
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters.Select(x => _mapper.Map<GetCharacterDto>(x)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterDto>();
            var character = characters.FirstOrDefault(c => c.Id == id); //1:03:00
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(characters);
            return serviceResponse;
        }
    }
}
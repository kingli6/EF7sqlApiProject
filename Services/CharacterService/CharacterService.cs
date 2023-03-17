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
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            characters.Add(_mapper.Map<Character>(newCharacter));
            serviceResponse.Data = characters.Select(x => _mapper.Map<GetCharacterDto>(x)).ToList();    //Select returns a Ienumerable. Look at what methods are at work when you get red 2:19:00
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
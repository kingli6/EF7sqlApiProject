using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrickGODWebApiEF7SQL
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Character, GetCharacterDto>();    //1:31:00 
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
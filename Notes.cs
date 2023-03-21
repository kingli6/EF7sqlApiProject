//Notes






// // Get all Categories                                                OrderBy
//         public async Task<List<CategoryViewModel>> GetAllCategoriesAsync()
//         {
//             return await _context.Categories
//                 .ProjectTo<CategoryViewModel>(_mapper.ConfigurationProvider)
//                 .OrderBy(c => c.Id)                                                              
//                 .ToListAsync();
//         }

// public IActionResult Index()
// {
//     var orders = context.orders
//         .Include(orders => orders.LineItems)
//         .ThenInclude(lineItem => lineItem.Product)
//         .Where(orders => order.OrderDate > DateTime.UtcNow.AddDays(-1)).ToList();... ) //https://app.pluralsight.com/course-player?clipId=09231630-49b5-4702-a2d8-4e4d46845713 2:13
// }







// // Get category by id    GET id
//         public async Task<CategoryViewModel> GetCategoryWithIdAsync(int id)
//         {
//             var response = await _context.Categories.FindAsync(id);

//             if (response == null)
//             {
//                 throw new NotFoundException();
//             }

//             return _mapper.Map<CategoryViewModel>(response);
//         }



// public Charactar GetCharactedById(int id)
// {
//     var character = character.FirstOrDefault(c => c.id == id);
//     if (character is not null)
//         return character;

//     throw new Exception("Character not found");
// }

// public async Task<ActionResult<List<Character>>> Get(int userId)
// {       //22:52  https://www.youtube.com/watch?v=FHx6AGVF_IE&list=WL&index=1&t=2s
//     var characters = await _context.characters
//         .Where(c => c.UserId == userId)
//         .ToListAsync();

//     return characters
// }

/*In summary, FindAsync is used to retrieve a single entity by its primary key, FirstOrDefault is used to retrieve the first entity that matches a specified condition, and .Where(x => x.userId == userId) is used to retrieve a subset of entities that match a specified condition.*/

// if (!_pieRepository.AllPies.Any(p => p.PieId == id))    //https://app.pluralsight.com/course-player?clipId=bcbf2d8f-8492-4558-95cd-5d0953d47c2a 2:41
//     return NotFound();

// return Ok(_pieRepository.AllPies.Where(p => p.PieId == id));

// .Where(p => p.Name.Contains(searchQuery));









// // Create category   POST
//         public async Task AddCategoryAsync(PostCategoryViewModel model)
//         {
//             await _context.Categories.AddAsync(_mapper.Map<Category>(model));
//         }

// public async Task<ActionResult<List<Character>>> Create(Character character)     //26:00 https://www.youtube.com/watch?v=FHx6AGVF_IE&list=WL&index=1&t=2s
// {
//     _context.Characters.Add(character);
//     await _context.SaveChangesAsync();

//     return await GetCharacterDto(character.UserId);
// }







// // Edit category   PUT
//         public async Task UpdateCategoryAsync(int id, PutCategoryViewModel model)

//         {
//             var response = await _context.Categories.FindAsync(id);

//             if (response == null)
//             {
//                 throw new NotFoundException();
//             }

//             _context.Categories.Update(_mapper.Map(model, response));
//         }














// // Delete category
// public async Task DeleteCategoyAsync(int id)
// {
//     var response = await _context.Categories.FindAsync(id);

//     if (response == null)
//     {
//         throw new NotFoundException();
//     }

//     _context.Categories.Remove(response);
// }



















// // Save all changes
//         public async Task<bool> SaveChangesAsync()
//         {
//             return await _context.SaveChangesAsync() > 0;
//         }
//     }













/*NOtes

nuget.org, we'll download AutoMapper package. 
    >>dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.0       //skip the --version... if it's not important

1:23:00 DTO's are classes that we use to send and retrieve object with limited properties. IF the model class has properties such as Id and password,
we shouldn't pass those back and forth through API's. Instead we use DTO that has enough properties so we don't expose sensitive information. 
Next step is to use automappers that maps from Dto's to model and back. so far we have;
    Models
    Iservices and Services
    Controllers
    Dto's 
    Mapper

1:15:00 so far. 
    We created CharacterService that does the retrieving of the data. Later,
    we create Service Response that sends the data but has the ability to add if it was successful or not, with a message.
    We have the controller that does the HTTP request. 

injecting ICharacterService into your controller //it's nice to know that you can bring in a file through depedency injection. 
    We are bringing in an interface. into the contructor   58:00  https://www.youtube.com/watch?v=9zJn3a7L1uE

        BUT IT WON*T work until you add builder.Services in program.cs

            builder.Services.AddScoped<ICharacterService, CharacterService>();  //1:00:00 https://www.youtube.com/watch?v=9zJn3a7L1uE
*/
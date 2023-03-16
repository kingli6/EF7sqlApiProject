//Notes






// // Get all Categories                                                OrderBy
//         public async Task<List<CategoryViewModel>> GetAllCategoriesAsync()
//         {
//             return await _context.Categories
//                 .ProjectTo<CategoryViewModel>(_mapper.ConfigurationProvider)
//                 .OrderBy(c => c.Id)                                                              
//                 .ToListAsync();
//         }










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

















// // Create category   POST
//         public async Task AddCategoryAsync(PostCategoryViewModel model)
//         {
//             await _context.Categories.AddAsync(_mapper.Map<Category>(model));
//         }









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


1:15:00 so far. 
    We created CharacterService that does the retrieving of the data. Later,
    we create Service Response that sends the data but has the ability to add if it was successful or not, with a message.
    We have the controller that does the HTTP request. 

injecting ICharacterService into your controller //it's nice to know that you can bring in a file through depedency injection. 
    We are bringing in an interface. into the contructor   58:00  https://www.youtube.com/watch?v=9zJn3a7L1uE

        BUT IT WON*T work until you add builder.Services in program.cs

            builder.Services.AddScoped<ICharacterService, CharacterService>();  //1:00:00 https://www.youtube.com/watch?v=9zJn3a7L1uE
*/
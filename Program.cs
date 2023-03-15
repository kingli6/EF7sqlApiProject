global using PatrickGODWebApiEF7SQL.Models; //https://www.youtube.com/watch?v=9zJn3a7L1uE timestamp 30:50
global using PatrickGODWebApiEF7SQL.Services.CharacterService;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICharacterService, CharacterService>();  //1:00:00 https://www.youtube.com/watch?v=9zJn3a7L1uE
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

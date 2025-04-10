using TesteRhex.Contexts;
using TesteRhexAPI.Repositories;
using TesteRhexAPI.Repositories.ToolRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Database

builder.Services.AddSqlite<ApplicationDbContext>("Data Source=./database.db");
builder.Services.AddScoped<ApplicationDbContext>();

#endregion

#region Repositories

builder.Services.AddScoped<IToolRepository, ToolRepository>();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

#endregion

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
using Microsoft.EntityFrameworkCore;
using todos_backend.Data;
using todos_backend.Service.Todos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TodosDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TodoDatabase"));
});

builder.Services.AddTransient<ITodosService, TodosService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(
    builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    }    
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

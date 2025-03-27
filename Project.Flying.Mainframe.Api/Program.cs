using Microsoft.EntityFrameworkCore;
using Project.Flying.Mainframe.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("StoreContext") ?? "Data Source=C:\\Users\\25729\\Project-Flying-Mainframe-api\\Project.Flying.Mainframe.Api\\store.db", b => b.MigrationsAssembly("Project.Flying.Mainframe.Data")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

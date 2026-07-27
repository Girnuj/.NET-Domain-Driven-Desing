using Microsoft.EntityFrameworkCore;
using Wpm.Management.Api.Application;
using Wpm.Management.Api.Infrastructure;
using Wpm.Management.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ManagementDbContext>(opt =>
{
    opt.UseSqlite("Data Source=Wpm.db");
});
builder.Services.AddScoped<IBreedService, BreedService>();
builder.Services.AddScoped<ManagementApplicationService>();
var app = builder.Build();

app.EnsureDbIsCreated();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

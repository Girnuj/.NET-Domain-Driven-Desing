using Microsoft.EntityFrameworkCore;
using Wpm.Clinic.Api.Application;
using Wpm.Clinic.Api.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ClinicDbContext>(options =>
{
    options.UseSqlite("Data Source=Wpm.db");
});

builder.Services.AddScoped<ClinicApplicationService>();

var app = builder.Build();

app.EnsureDbIsCreated();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using Wpm.Management.Api.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ManagementDbContext>(opt =>
{
    opt.UseSqlite("Data Source=Wpm.db");
});

var app = builder.Build();

app.EnsureDbIsCreated();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using AutenticationService.Infrastructure;
using AuthenticationService.Infrastructure;
using Microsoft.EntityFrameworkCore;
using NorthwindDataAccess;
using NorthWindDataAccess;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
//.NET 6.0-- > using System.Configuration
builder.Services.AddDbContext<CapgUserDBContent>(options =>
{
 options.UseSqlServer(
 connectionString: "server=LAPTOP-SF5JKCA0\\SQLEXPRESS;database=CapgUsersDB;integrated security=true",b=>b.MigrationsAssembly("AutenticationService"));
});
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddScoped<UsersDAO>();
var app = builder.Build();
app.UseMiddleware<JwtMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())    
{   
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseMiddleware<JwtMiddleware>
app.UseAuthorization();


app.MapControllers();


app.Run();

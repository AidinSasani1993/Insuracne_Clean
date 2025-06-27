using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QBimeh.AdminApi.Extentions;
using QBimeh.Application.Services.Roles;
using QBimeh.Application.Services.Users;
using QBimeh.Domain.Entities.Users;
using QBimeh.EntityFramework.DatabaseContext;
using QBimeh.Service.Roles;
using QBimeh.Service.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


#region [-AddDbContext-]
builder.Services.AddDbContext<QBimehDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
#endregion

builder.Services.AddScoped<IUserService, UserService>()
.AddScoped<IRoleService, RoleService>()
.AddIdentity<User, IdentityRole>()
        .AddEntityFrameworkStores<QBimehDbContext>()
        .AddDefaultTokenProviders();

builder.Services.ConfigureJWT(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

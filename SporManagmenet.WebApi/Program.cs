using Microsoft.EntityFrameworkCore;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Repository.Concretes;
using SporManagmenet.WebApi.Repository.Contexts;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Services.Concretes;
using SporManagmenet.WebApi.Services.Helpers.CloudinaryHelper;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


// Repository Baðýmlýlýklarý
builder.Services.AddScoped<ICoachRepository, CoachRepository>();
builder.Services.AddScoped<ICountryRepository,CountryRepository>();
builder.Services.AddScoped<IPlayerImageRepository, PlayerImageRepository>();
builder.Services.AddScoped<IPlayerRepository,PlayerRepository>();
builder.Services.AddScoped<ITeamRepository,TeamRepository>();
builder.Services.AddDbContext<BaseDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"));
});


builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));



// Service baðýmlýlýklarý
builder.Services.AddScoped<ITeamService,TeamService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IPlayerImageService,PlayerImageService>();
builder.Services.AddScoped<ICountryService,CountryService>();
builder.Services.AddScoped<ICoachService,CoachService>();
builder.Services.AddScoped<ICloudinaryService,CloudinaryService>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

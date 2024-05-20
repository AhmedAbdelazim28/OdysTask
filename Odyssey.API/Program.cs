using Microsoft.EntityFrameworkCore;
using Odysseycs.Application.Interfaces;
using Odysseycs.Infra;
using Odysseycs.Infra.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


#region Add services to the container
//Add Services
//builder.Services.AddScoped<IstockExchangeService, StockExchangeService>();
//builder.Services.AddScoped<IstockOrderService, StockOrderService>();
//builder.Services.AddScoped<IstockPriceService, StockPriceService>();
#endregion

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DB Context & Unit Of Work Config
builder.Services.AddDbContext<UniversityDbContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("MainConnectionString"))
);
builder.Services.AddScoped<IUniversityDbContext, UniversityDbContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

#endregion

#region Auto Mapper Config
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
#endregion

#region Cors Config
builder.Services.AddCors(options =>
{
    options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});
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

app.UseCors("Open");

app.MapControllers();

app.Run();
